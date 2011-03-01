using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;




namespace Model
{
    public class NyhedCollection
    {
        List<Nyhed> nyheder;

        public NyhedCollection()
        {
            nyheder = new List<Nyhed>();
        }


        public void OpretNyhed(long id, string nyhedtext, DateTime dato)
        {
            Nyhed nyhed = new Nyhed(id, nyhedtext, dato);
            nyheder.Add(nyhed);
        }

        public bool RetNyhed(long id, string nyhedtext, DateTime dato)
        {
            Nyhed nyhed = FindNyhed(id);
            if (nyhed != null)
            {
                nyhed.NyhedText = nyhedtext;
                nyhed.Dato = dato;
                return true;
            }
            return false;
        }

        public bool SletNyhed(long id)
        {
            Nyhed nyhed = FindNyhed(id);
            if (nyhed != null)
            {
                nyheder.Remove(nyhed);
                return true;
            }
            return false;
        }


        public Nyhed FindNyhed(long ID)
        {
            foreach (Nyhed nyhed in nyheder)
            {
                if (ID == nyhed.ID)
                {
                    return nyhed;
                }
            }

            return null;
        }

        public IEnumerator GetNyhed()
        {
            return nyheder.GetEnumerator();
        }


    }
}
