using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BF_OKS;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;


namespace Database
{
    class Personale
    {
        private string sql = @"Data Source= linux1.tietgen.dk;Initial Catalog=gruppe10;User Id=gruppe10;Password=cehEk2busP";
        private string sql_proc;
        SqlCommand cmd;
        SqlConnection conn;

        public Personale()
        {
            cmd = new SqlCommand();
            conn = new SqlConnection(sql);
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
        }

        #region query
        public List<Medarbejder> /*Medarbejder*/ FindPersonale(string navn)
        {
            long cpr_nummer;
            string dbnavn;
            string adresse;
            int postnr;
            long tlf;
            int afdeling;

            SqlDataReader reader;


            List<Medarbejder> medarbejdere = new List<Medarbejder>();
            cmd.Parameters.Clear();
            cmd.CommandText = "FindPersonaleNavn";

            SqlParameter par = new SqlParameter("@navn", SqlDbType.NVarChar);
            par.Value = navn;
            cmd.Parameters.Add(par);
            Medarbejder medarbejder = null;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                


                while (reader.Read())
                {
                    cpr_nummer = (long)reader["cpr_ID"];
                    dbnavn = (string)reader["navn"];
                    adresse = (string)reader["adresse"];
                    postnr = (int)reader["Postnr_FID"];
                    tlf = (long)reader["tlf"];
                    afdeling = (int)reader["afd_FID"];

                    medarbejder = new Medarbejder(cpr_nummer, dbnavn, adresse, postnr, tlf, afdeling);

                    medarbejdere.Add(medarbejder);
                }
                conn.Close();
            }
            catch (SqlException e)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                throw e;
            }

            return medarbejdere;
        }

     

        public Medarbejder FindPersonale(long cpr_nummer)
        {
            long dbcpr_nummer;
            string navn;
            string adresse;
            int postnr;
            long tlf;
            int afdeling;

            SqlDataReader reader;

            cmd.Parameters.Clear();
            cmd.CommandText = "FindPersonaleCpr";

            SqlParameter par = new SqlParameter("@cpr_ID", SqlDbType.NVarChar);
            par.Value = cpr_nummer;
            cmd.Parameters.Add(par);

            Medarbejder medarbejder = null;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dbcpr_nummer = (long)reader["cpr_ID"];
                    navn = (string)reader["navn"];
                    adresse = (string)reader["adresse"];
                    postnr = (int)reader["Postnr_FID"];
                    tlf = (long)reader["tlf"];
                    afdeling = (int)reader["afd_FID"];

                    medarbejder = new Medarbejder(dbcpr_nummer, navn, adresse, postnr, tlf, afdeling);
                }
            }
            catch (SqlException e)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                throw (e);
            }

            return medarbejder;
        }



        public List<Fravær> FindFravær(long cpr_nummer, DateTime dato_fra, DateTime dato_til)
        {
            string type;
            DateTime dato_start;
            DateTime dato_slut;
            List<Fravær> fravære = new List<Fravær>();
            Fravær fravær;

            SqlDataReader reader;

            cmd.Parameters.Clear();
            cmd.CommandText = "FindSyg";

            SqlParameter par;

            par = new SqlParameter("@cpr", SqlDbType.BigInt);
            par.Value = cpr_nummer;
            cmd.Parameters.Add(par);

            par = new SqlParameter("@dato_fra", SqlDbType.Date);
            par.Value = dato_fra;
            cmd.Parameters.Add(par);

            par = new SqlParameter("@dato_til", SqlDbType.Date);
            par.Value = dato_til;
            cmd.Parameters.Add(par);

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    type = (string)reader["type"];
                    dato_start = (DateTime)reader["dato_fra"];
                    dato_slut = (DateTime)reader["dato_til"];

                    fravær = new Fravær(type, dato_start, dato_slut);
                    fravære.Add(fravær);
                }
                conn.Close();
            }
            catch (SqlException e)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                throw (e);
            }
            return fravære;
        }



        #endregion

        #region nonquery

        public string OpretFravær(string cpr_nummer, string type, DateTime dato_fra, DateTime dato_til)
        {
            string sqlfejl =null;

            cmd.CommandText = "OpretFravær";

            cmd.Parameters.Clear();

            SqlParameter par;
 
            par = new SqlParameter("@cpr_ID", SqlDbType.BigInt);
            par.Value = cpr_nummer;
            cmd.Parameters.Add(par);

            par = new SqlParameter("@type", SqlDbType.NVarChar);
            par.Value = type;
            cmd.Parameters.Add(type);

            par = new SqlParameter("@dato_fra", SqlDbType.Date);
            par.Value = dato_fra;
            cmd.Parameters.Add(dato_fra);

            par = new SqlParameter("@dato_til", SqlDbType.Date);
            par.Value = dato_til;
            cmd.Parameters.Add(dato_til);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (SqlException e)
            {
                if (e.Number == 2627)
                {
                    sqlfejl = "Fraværet findes allerede";
                }
                else
                {
                    sqlfejl = "Fraværet kunne ikke oprettes" + e.Number;
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return sqlfejl;

        }

        public string OpretAfdeling(string afdeling, int afd)
        {
            string sqlfejl = null;

            cmd.CommandText = "OpretAfdeling";
            cmd.Parameters.Clear();

            SqlParameter par;

            par = new SqlParameter("@afdeling", SqlDbType.NVarChar);
            par.Value = afdeling;
            cmd.Parameters.Add(par);

            par = new SqlParameter("@afd", SqlDbType.NVarChar);
            par.Value = afd;
            cmd.Parameters.Add(par);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (SqlException e)
            {
                if (e.Number == 2627)
                {
                    sqlfejl = "Afdelingen findes allerede";
                }
                else
                {
                    sqlfejl = "Der skete en fejl under oprettelsen af afdelingen:" + e.Number;
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return sqlfejl;
        }

        public string OpretBy(int postnr, string distrikt)
        {
            string sqlfejl = null;

            cmd.CommandText = "OpretBy";
            cmd.Parameters.Clear();

            SqlParameter par;

            par = new SqlParameter("@postnr", SqlDbType.Int);
            par.Value = postnr;
            cmd.Parameters.Add(par);

            par = new SqlParameter("@distrikt", SqlDbType.NVarChar);
            par.Value = distrikt;
            cmd.Parameters.Add(par);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (SqlException e)
            {
                if (e.Number == 2627)
                {
                    sqlfejl = "Districkt findes allerede";
                }
                else
                {
                    sqlfejl = "Der skete en fejl under opretningen af Districkt" + e.Number; 
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return sqlfejl;
        }

        public string OpretMedarbejder(int cpr, string navn, string adresse, int postnr, long tlf, int afd)
        {
            string sqlfejl = null;

            cmd.CommandText = "OpretMedarbejder";
            cmd.Parameters.Clear();

            SqlParameter par;

            par = new SqlParameter("@cpr",SqlDbType.NVarChar);
            par.Value = cpr;
            cmd.Parameters.Add(par);

            par = new SqlParameter("@navn", SqlDbType.NVarChar);
            par.Value = navn;
            cmd.Parameters.Add(par);

            par = new SqlParameter("@adresse",SqlDbType.NVarChar);
            par.Value = adresse;
            cmd.Parameters.Add(par);

            par = new SqlParameter("@postnr", SqlDbType.Int);
            par.Value = postnr;
            cmd.Parameters.Add(par);

            par = new SqlParameter("@tlf", SqlDbType.BigInt);
            par.Value = tlf;
            cmd.Parameters.Add(par);

            par = new SqlParameter("@afd", SqlDbType.Int);
            par.Value = afd;
            cmd.Parameters.Add(par);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                if (e.Number == 2627)
                {
                    sqlfejl = "Medarbejder findes allerede i katoteket";
                }
                else
                {
                    sqlfejl = "Der er sket en fejl under oprettelsen af Medarbejder" + e.Number;
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return sqlfejl;
        }



            
        


        #endregion


    }
}
