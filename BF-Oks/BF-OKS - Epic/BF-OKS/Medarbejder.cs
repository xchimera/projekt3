using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BF_OKS
{
    public class Medarbejder
    {
        string cpr_nummer;
        string navn;
        string adresse;
        int postnr;
        long tlf;
        int afdelingsid;
        Fravær fravær;
        private List<Fravær> fravære;


        public Medarbejder(string cpr_nummer, string navn, string adresse, int postnr, long tlf, int afdelingsid)
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
    }
}
