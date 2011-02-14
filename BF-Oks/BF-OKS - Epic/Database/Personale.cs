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
        private string sql = @"Data Source= linux1.tietgen.dk;Initial Catalog=gruppe10;Integrated Security=SSPI";
        private string sql_proc;
        SqlCommand com;
        SqlConnection conn;

        public Personale()
        {
            com = new SqlCommand();
            conn = new SqlConnection(sql);
            com.Connection = conn;
        }

        public Medarbejder FindPersonale(string navn)
        {
            long cpr_nummer;
            string dbnavn;
            string adresse;
            int postnr;
            long tlf;
            int afdeling;

            List<Medarbejder> medarbejdere = new List<Medarbejder>();
            com.Parameters.Clear();
            com.CommandText = "FindPersonaleNavn";







            return null;
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
