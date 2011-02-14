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

        public /*List<Medarbejder>*/ Medarbejder FindPersonale(string navn)
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

            return medarbejder;
        }

     

        public Medarbejder FindPersonale(long cpr_nummer)
        {

            return null;
        }

        public bool OpretFravær(string cpr_nummer)
        {

            return false;
        }

        public void UdtrækFravær(string cpr_nummer)
        {

        }
    }
}
