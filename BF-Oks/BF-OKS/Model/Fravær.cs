using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Interfaces;

namespace Model
{
    public class Fravær : IFraværData
    {
        private int Type { get; set; }
        private DateTime Dato_fra { get; set; }
        private DateTime Dato_til { get; set; }



        public Fravær(int type, DateTime dato_fra, DateTime dato_til)
        {
            this.Type = type;
            this.Dato_fra = dato_fra;
            this.Dato_til = dato_til;
        }
    }
}
