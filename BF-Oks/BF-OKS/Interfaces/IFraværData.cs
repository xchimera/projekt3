﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public interface IFraværData
    {
        string Type { get; }
        string Note { get;}
        DateTime Dato_fra { get; }
        DateTime Dato_til { get; }
    }
}
