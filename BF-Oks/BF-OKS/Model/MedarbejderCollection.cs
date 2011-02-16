using System.Collections.Generic;

namespace BF_OKS
{
    public class MedarbejderCollection
    {
        private List<Medarbejder> medarbejderer;

        public MedarbejderCollection()
        {
            medarbejderer = new List<Medarbejder>();
        }

        public Medarbejder OpretMedarbejder(long cpr_nummer, string navn, string adresse, int postnr, long tlf,
                                            int afdelingsid)
        {
            var medarbejder = new Medarbejder(cpr_nummer, navn, adresse, postnr, tlf, afdelingsid); // skab medarbejder
            medarbejderer.Add(medarbejder); // smid medarbejder  i liste
            return medarbejder;
        }

        public Medarbejder FindMedarbejder(long cpr_nummer)
        {
            int i = 0;
            long cpr_nummerIdx = medarbejderer[i].Cpr_nummer;
            while (cpr_nummer != cpr_nummerIdx)
            {
                i++;
                cpr_nummerIdx = medarbejderer[i].Cpr_nummer;
            }
            return medarbejderer[i];
        }
    }
}
