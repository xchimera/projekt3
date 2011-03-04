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

        #region Opret, Rediger & Slet medarbejder
        public void OpretMedarbejder(long cpr_nummer, string navn, string adresse, int postnr, string by, long tlf, int afdelingsid)
        {
            Medarbejder medarbejder = new Medarbejder(cpr_nummer, navn, adresse, postnr, by, tlf, afdelingsid); // skab medarbejder
            ListMedarbejdere.Add(medarbejder); // smid medarbejder  i liste
        }

        public void RedigerMedarbejder(long cpr_nummer, string navn, string adresse, int postnr, long tlf, int afdelingsid)
        {
            Medarbejder medarbejder = FindMedarbejder(cpr_nummer);
            medarbejder.Navn = navn;
            medarbejder.Adresse = adresse;
            medarbejder.Postnr = postnr;
            medarbejder.Tlf = tlf;
            medarbejder.Afdelingsid = afdelingsid;
        }

        public void SletMedarbejder(long cpr_nummer)
        {
            Medarbejder medarbejder = FindMedarbejder(cpr_nummer);
            ListMedarbejdere.Remove(medarbejder);
        }
        #endregion

        public void OpretFravær(long cpr_nummer, DateTime dato_fra, DateTime dato_til, string note, string type, int id)
        {
            foreach (Medarbejder MedArb in ListMedarbejdere)
	        {
                if (MedArb.Cpr_nummer == cpr_nummer)
	            {
                    MedArb.OpretFravær(type, note, dato_fra, dato_til, id);
                    break;
	            }
	        }
        }
        public void RedigerFravær(long cpr_nummer, DateTime dato_fra, DateTime dato_til, string note, string type)
        { //TODO: RedigérFravær!!!!!
            Medarbejder medarbejder = FindMedarbejder(cpr_nummer);
            if (medarbejder.Cpr_nummer == cpr_nummer)
            {
                
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
