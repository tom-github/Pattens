using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    abstract class Elemento
    {
        public abstract void aceita(IVisitante visitante);
    }
}
