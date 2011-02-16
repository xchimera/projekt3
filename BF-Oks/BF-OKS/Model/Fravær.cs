using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BF_OKS
{
    public class Fravær
    {
        private int type;
        private DateTime dato_fra;
        private DateTime dato_til;

        public Fravær(int type, DateTime dato_fra, DateTime dato_til)
        {
            this.type = type;
            this.dato_fra = dato_fra;
            this.dato_til = dato_til;
        }
    }
}
