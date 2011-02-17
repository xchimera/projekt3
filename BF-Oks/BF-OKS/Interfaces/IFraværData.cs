using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public interface IFraværData
    {
        int Type { get; }
        DateTime Dato_fra { get; }
        DateTime Dato_til { get; }
    }
}
