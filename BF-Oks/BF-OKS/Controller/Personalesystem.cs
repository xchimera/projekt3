﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

using Model;

namespace Controller
{
    public class Personalesystem
    {
        DBFacade dbfacade;
        MedarbejderCollection medarbejdercollection;
        

        public Personalesystem()
        {
            dbfacade = new DBFacade(this);
            medarbejdercollection = new MedarbejderCollection();
            dbfacade.LoadMedarbejdere();

        }

        public bool RedigerMedarbejder(long cpr, string navn, string adresse, int postnr, long tlf, int afd)
        {
            if (dbfacade.RedigerMedarbejder(cpr, navn, adresse, postnr, tlf, afd) == null)
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
        public bool OpretMedarbejder(string navn, long cpr_nummer, string adresse, int postnr, long tlf, int afdelingsid)
        {
            if (dbfacade.OpretMedarbejder(cpr_nummer, navn, adresse, postnr, tlf, afdelingsid) == null)
            {
                medarbejdercollection.OpretMedarbejder(cpr_nummer, navn, adresse, postnr, tlf, afdelingsid);
                return true;
            }
            return false;
        }

        public void TilføjMedarbejder(string navn, long cpr_nummer, string adresse, int postnr, long tlf, int afdelingsid)
        {
            medarbejdercollection.OpretMedarbejder(cpr_nummer, navn, adresse, postnr, tlf, afdelingsid);
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

        public string OpretNyhed(string nyhed)
        {
            return dbfacade.OpretNyhed(nyhed);
        }


        public bool SletMedarbejder(long cpr_nummer)
        {
            if (dbfacade.SletMedarbejder(cpr_nummer) == null)
            {
                return true;
            }
            return false;
        }

        public bool SletNyhed()
        {
            if (dbfacade.SletNyhed() != null)
            {
                return true;
            }
            return false;
        }


        public IEnumerator GetMedarbejderIterator()
        {
            return medarbejdercollection.GetMedarbejderIterator();
        }
    }
}
