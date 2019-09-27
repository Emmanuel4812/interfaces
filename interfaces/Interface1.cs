using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    interface Dibujable
    {
        void Dibujar();

    }
    interface EsDibujable : Dibujable
    {
        bool PuedeDibujarse { get; }
    }
}
