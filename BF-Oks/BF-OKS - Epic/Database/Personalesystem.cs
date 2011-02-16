using System;
using System.Collections.Generic;
using BF_OKS;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace Database
{
    public class Personalesystem
    {
        DBFacade personale;

        public Personalesystem()
        {
            personale = new DBFacade();
        }


        public Medarbejder FindPersonale(string navn)
        {
            Medarbejder medarbejder = personale.FindPersonale(navn);

            return medarbejder;
        }
    }
}
