using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class Presidente: Empregado
    {
        // Construtor
        public Presidente()
            : base("Pedro", 45000.0, 21)
        {
        }
    }
}
