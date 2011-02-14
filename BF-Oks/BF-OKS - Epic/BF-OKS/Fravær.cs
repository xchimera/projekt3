using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BF_OKS
{
    class Fravær
    {
        private string type;
        private DateTime dato_fra;
        private DateTime dato_til;

        public Fravær(string type, DateTime dato_fra, DateTime dato_til)
        {
            this.type = type;
            this.dato_fra = dato_fra;
            this.dato_til = dato_til;
        }
    }
}
