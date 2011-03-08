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

        public Model.MedarbejderCollection MedarbejderCollection
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Model.NyhedCollection NyhedCollection
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal DBFacade DBFacade
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public bool RedigerMedarbejder(long cpr, string navn, string adresse, int postnr, string by, long tlf, int afd)
        {
            if (dbfacade.RedigerMedarbejder(cpr, navn, adresse, postnr, by, tlf, afd) == null)
            {
                medarbejdercollection.RedigerMedarbejder(cpr, navn, adresse, postnr, tlf, afd);

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
        public void TilføjFravær(long cpr_nummer, DateTime dato_fra, DateTime dato_til, string note, string type, int id)
        {
            medarbejdercollection.OpretFravær(cpr_nummer, dato_fra, dato_til, note, type, id);
            
        }

        public bool OpretFravær(long cpr_nummer, DateTime dato_fra, DateTime dato_til, string note, string type)
        {
            int id = dbfacade.OpretFravær(cpr_nummer, note, type, dato_fra, dato_til);
           
            medarbejdercollection.OpretFravær(cpr_nummer, dato_fra, dato_til, note, type, id);
            return true;

            
        }
        
        public bool RedigerFravær(long cprnummer,int id, DateTime dato_fra, DateTime dato_til, string note, string type)
        {
            if (dbfacade.RedigerFravær(cprnummer, id, dato_fra, dato_til, note, type) == true)
            {
                if (medarbejdercollection.RedigerFravær(cprnummer, id, dato_fra, dato_til, note, type))
                {
                    return true;
                }
            }
            return false;
        }



        public bool SletMedarbejder(long cpr_nummer)
        {
            if (dbfacade.SletMedarbejder(cpr_nummer) == null)
            {
                medarbejdercollection.SletMedarbejder(cpr_nummer);
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

        public long OpretNyhed(string nyhedtext, DateTime dato)
        {
            long id = dbfacade.OpretNyhed(nyhedtext, dato);

            nyhedcollection.OpretNyhed(id, nyhedtext, dato);

            return id;
        }




        public IEnumerator GetMedarbejderIterator()
        {
            return medarbejdercollection.GetMedarbejderIterator();
        }

        public IEnumerator GetFraværIterator(long cpr_nummer)
        {
            return medarbejdercollection.GetFraværIterator(cpr_nummer);
        }

        public IEnumerator GetNyhed()
        {
            return nyhedcollection.GetNyhed();
        }
      
        
    }
}
