using System;
using System.Collections.Generic;
using BF_OKS;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace Database
{
    public class DB_Sql
    {
        Personale personale;

        public DB_Sql()
        {
            personale = new Personale();
        }


        public Medarbejder FindPersonale(string navn)
        {
            Medarbejder medarbejder = personale.FindPersonale(navn);

            return medarbejder;
        }
    }
}
