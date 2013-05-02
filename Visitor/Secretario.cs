using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class Secretario: Empregado
    {
        // Construtor
        public Secretario()
            : base("João", 25000.0, 14)
        {
        }
    }
}
