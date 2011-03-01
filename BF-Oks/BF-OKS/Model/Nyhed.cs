using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Nyhed
    {

        private long Id;
        private string nyhed;
        private DateTime dato;

        public Nyhed(long ID, string nyhed, DateTime dato)
        {

        }


        
        public long ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public string NyhedText
        {
            get { return nyhed; }
            set { nyhed = value; }
        }
        public DateTime Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        
    }
}
