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
        DBFacade DBfac;
        

        public Personalesystem()
        {
            //TODO: Kode, hvis der er noget?
        }

        // Tilføjer
        public void TilføjMedarbejder(string navn, long cpr_nummer, string adresse, int postnr, long tlf, int afdelingsid)
        {

        }

        public void OpretFravær(long cpr_nummer, DateTime dato_fra, DateTime dato_til, string note, int type)
        {

        }
    }
}
