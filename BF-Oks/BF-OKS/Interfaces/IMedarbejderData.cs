using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    interface IMedarbejderData
    {
        long Cpr_nummer { get; }
        string Navn { get; }
        string Adresse { get; }
        int Postnr { get; }
        long Tlf { get; }
        int Afdelingsid { get; }

    }
}
