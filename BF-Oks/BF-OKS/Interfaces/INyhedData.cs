using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public interface INyhedData
    {
        long ID { get; }
        string NyhedText {get;}
        DateTime Dato { get; }

    }
}
