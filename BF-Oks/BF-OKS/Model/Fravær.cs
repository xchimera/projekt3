using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Interfaces;

namespace Model
{
    public class Fravær : IFraværData
    {
        public string Type { get; set; }
        public string Note { get; set; }
        public DateTime Dato_fra { get; set; }
        public DateTime Dato_til { get; set; }



        public Fravær(string type, string note, DateTime dato_fra, DateTime dato_til)
        {
            this.Type = type;
            this.Note = note;
            this.Dato_fra = dato_fra;
            this.Dato_til = dato_til;
        }
    }
}
