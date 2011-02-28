using System.Collections;
using System.Collections.Generic;
using System;

namespace Model
{
    public class MedarbejderCollection
    {
        private List<Medarbejder> ListMedarbejdere;

        public MedarbejderCollection()
        {
            ListMedarbejdere = new List<Medarbejder>();
        }

        public void OpretMedarbejder(long cpr_nummer, string navn, string adresse, int postnr, long tlf,
                                            int afdelingsid)
        {
            Medarbejder medarbejder = new Medarbejder(cpr_nummer, navn, adresse, postnr, tlf, afdelingsid); // skab medarbejder
            ListMedarbejdere.Add(medarbejder); // smid medarbejder  i liste
        }

        public void OpretFravær(long cpr_nummer, DateTime dato_fra, DateTime dato_til, string note, string type)
        {
            foreach (Medarbejder MedArb in ListMedarbejdere)
	        {
                if (MedArb.Cpr_nummer == cpr_nummer)
	            {
                    MedArb.OpretFravær(type, note, dato_fra, dato_til);
                    break;
	            }
	        }
        }

        public Medarbejder FindMedarbejder(long cpr_nummer)
        {
            int i = 0;
            long cpr_nummerIdx = ListMedarbejdere[i].Cpr_nummer;
            while (cpr_nummer != cpr_nummerIdx)
            {
                i++;
                cpr_nummerIdx = ListMedarbejdere[i].Cpr_nummer;
            }
            return ListMedarbejdere[i];
        }

        public IEnumerator GetMedarbejderIterator()
        {
            return ListMedarbejdere.GetEnumerator();
        }

        public IEnumerator GetFraværIterator(long cpr_nummer)
        {
            Medarbejder medarbejder = FindMedarbejder(cpr_nummer);

            return medarbejder.GetFravær();
        }

        
    }
}
