using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using Interfaces;
using Model;

namespace Controller
{
    public class Personalesystem
    {
        DBFacade dbfacade;
        MedarbejderCollection medarbejdercollection;
        NyhedCollection nyhedcollection;

        public Personalesystem()
        {
            dbfacade = new DBFacade(this);
            medarbejdercollection = new MedarbejderCollection();
            nyhedcollection = new NyhedCollection();
            dbfacade.LoadMedarbejdere();

        }

        public bool RedigerMedarbejder(long cpr, string navn, string adresse, int postnr, string by, long tlf, int afd)
        {
            if (dbfacade.RedigerMedarbejder(cpr, navn, adresse, postnr, by, tlf, afd) == null)
            {
                //TODO kald til rediger medarbejder

                return true;
            }
            return false;
        }

        public Medarbejder FindMedarbejder(long cpr_nummer)
        {
            return medarbejdercollection.FindMedarbejder(cpr_nummer);
        }

        // Tilføjer medarbejder til systemet
        public bool OpretMedarbejder(string navn, long cpr_nummer, string adresse, int postnr, string by, long tlf, int afdelingsid)
        {
            if (dbfacade.OpretMedarbejder(cpr_nummer, navn, adresse, postnr, tlf, afdelingsid) == null)
            {
                medarbejdercollection.OpretMedarbejder(cpr_nummer, navn, adresse, postnr, by, tlf, afdelingsid);
                return true;
            }
            return false;
        }

        public void TilføjMedarbejder(string navn, long cpr_nummer, string adresse, int postnr, string by, long tlf, int afdelingsid)
        {
            medarbejdercollection.OpretMedarbejder(cpr_nummer, navn, adresse, postnr, by, tlf, afdelingsid);
        }
        

        // Tilføjer et objekt af fravær til en valgt medarbejder
        public void TilføjFravær(long cpr_nummer, DateTime dato_fra, DateTime dato_til, string note, string type)
        {
            medarbejdercollection.OpretFravær(cpr_nummer, dato_fra, dato_til, note, type);
            
        }

        public bool OpretFravær(long cpr_nummer, DateTime dato_fra, DateTime dato_til, string note, string type)
        {
            if (dbfacade.OpretFravær(cpr_nummer, note, type, dato_fra, dato_til) == null)
            {
                medarbejdercollection.OpretFravær(cpr_nummer, dato_fra, dato_til, note, type);
                return true;
            }
            return false;
        }

        //public long OpretNyhed(string nyhed)
        //{
        //    return dbfacade.OpretNyhed(nyhed);
        //}


        public bool SletMedarbejder(long cpr_nummer)
        {
            if (dbfacade.SletMedarbejder(cpr_nummer) == null)
            {
                return true;
            }
            return false;
        }

        public bool RetNyhed(long id, string nyhed, DateTime dato)
        {
            if (dbfacade.RetNyhed(id, nyhed, dato) != null)
            {
                return true;
            }
            return false;
        }


        public void TilføjNyhed(long id, string nyhedtext, DateTime dato)
        {
            nyhedcollection.OpretNyhed(id, nyhedtext, dato);

        }

        public void OpretNyhed(string nyhedtext, DateTime dato)
        {
            long id = dbfacade.OpretNyhed(nyhedtext, dato);

            nyhedcollection.OpretNyhed(id, nyhedtext, dato);
           
        }

        public void IndsætNyhed(long id, string nyhedtext, DateTime dato)
        {
        }


        public IEnumerator GetMedarbejderIterator()
        {
            return medarbejdercollection.GetMedarbejderIterator();
        }

        public IEnumerator GetFraværIterator(long cpr_nummer)
        {
            return medarbejdercollection.GetFraværIterator(cpr_nummer);
        }


        //TODO: lav en load for nyhed
        //TODO: lav samme måde at loade nyhed som medarbejder
        
    }
}
