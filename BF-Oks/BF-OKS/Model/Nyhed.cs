using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;


namespace Model
{
    public class Nyhed : Interfaces.INyhedData
    {

        private long Id;
        private string nyhed;
        private DateTime dato;

        public Nyhed(long ID, string nyhed, DateTime dato)
        {
            this.Id = ID;
            this.nyhed = nyhed;
            this.dato = dato;
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
