﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Model
{
    public class Medarbejder : Interfaces.IMedarbejderData
    {
        long cpr_nummer;
        string navn;
        string adresse;
        int postnr;
        string by;
        long tlf;
        int afdelingsid;
        private List<Fravær> listFravær;        


        public Medarbejder(long cpr_nummer, string navn, string adresse, int postnr, string by, long tlf, int afdelingsid)
        {
            this.cpr_nummer = cpr_nummer;
            this.navn = navn;
            this.adresse = adresse;
            this.postnr = postnr;
            this.by = by;
            this.tlf = tlf;
            this.afdelingsid = afdelingsid;
            listFravær = new List<Fravær>();
        }

        public void OpretFravær(string type, string note, DateTime dato_fra, DateTime dato_til, int id)
        {
            Fravær fravær = new Fravær(type, note, dato_fra, dato_til, navn, id);
            listFravær.Add(fravær);
        }

        public bool RedigerFravær(int id, DateTime dato_fra, DateTime dato_til, string note, string type)
        {
            Fravær fravær = FindFravær(id);
            if (fravær != null)
            {
                fravær.Dato_fra = dato_fra;
                fravær.Dato_til = dato_til;
                fravær.Note = note;
                fravær.Type = type;
                return true;
            }
            return false;
        }

        private Fravær FindFravær(int id)
        {
            foreach (Fravær fravær in listFravær)
            {
                if (id == fravær.ID)
                {
                    return fravær;
                }
            }
            return null;
        }

        public IEnumerator GetFravær()
        {
            return listFravær.GetEnumerator();
        }


        // Get & Set metoder

        public long Cpr_nummer
        {
            get { return cpr_nummer; }
            set { cpr_nummer = value; }
        }

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public int Postnr
        {
            get { return postnr; }
            set { postnr = value; }
        }

        public long Tlf
        {
            get { return tlf; }
            set { tlf = value; }
        }

        public int Afdelingsid
        {
            get { return afdelingsid; }
            set { afdelingsid = value; }
        }

        internal Fravær Fravær
        {
            get { return Fravær; }
            set { Fravær = value; }
        }

        public string By
        {
            get { return by; }
            set { by = value; }
        }

        public NyhedCollection NyhedCollection
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
