using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BF_OKS
{
    public class Medarbejder
    {
        long cpr_nummer;
        string navn;
        string adresse;
        int postnr;
        long tlf;
        int afdelingsid;
        Fravær fravær;
        private List<Fravær> fravære;        


        public Medarbejder(long cpr_nummer, string navn, string adresse, int postnr, long tlf, int afdelingsid)
        {
            this.cpr_nummer = cpr_nummer;
            this.navn = navn;
            this.adresse = adresse;
            this.postnr = postnr;
            this.tlf = tlf;
            this.afdelingsid = afdelingsid;
            fravære = new List<Fravær>();
        }

        public void OpretFravær(string type, DateTime dato_fra, DateTime dato_til)
        {
            fravær = new Fravær(type, dato_fra, dato_til);
            fravære.Add(fravær);
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
            get { return fravær; }
            set { fravær = value; }
        }
    }
}
