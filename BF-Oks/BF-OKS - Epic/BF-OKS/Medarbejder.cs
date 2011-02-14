using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BF_OKS
{
    class Medarbejder
    {
        string cpr_nummer;
        string navn;
        string adresse;
        int postnr;
        long tlf;
        int afdelingsid;

        public Medarbejder(string cpr_nummer, string navn, string adresse, int postnr, long tlf, int afdelingsid)
        {
            this.cpr_nummer = cpr_nummer;
            this.navn = navn;
            this.adresse = adresse;
            this.postnr = postnr;
            this.tlf = tlf;
            this.afdelingsid = afdelingsid;
        }
    }
}
