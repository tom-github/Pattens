using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    interface IVisitante
    {
        void visitar(Elemento elemento);
    }
}
