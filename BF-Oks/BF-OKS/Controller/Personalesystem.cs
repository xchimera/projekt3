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
        MedarbejderCollection MedArbCol;
        

        public Personalesystem()
        {
            //TODO: Kode, hvis der er noget?
        }

        // Tilføjer
        public void TilføjMedarbejder(string navn, long cpr_nummer, string adresse, int postnr, long tlf, int afdelingsid)
        {
            MedArbCol.OpretMedarbejder(cpr_nummer, navn, adresse, postnr, tlf, afdelingsid);
        }

        public void OpretFravær(long cpr_nummer, DateTime dato_fra, DateTime dato_til, string note, int type)
        {
            MedArbCol.OpretFravær(cpr_nummer, dato_fra, dato_til, note, type);
        }
    }
}
