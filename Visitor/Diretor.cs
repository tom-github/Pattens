using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class Diretor: Empregado
    {
        // Construtor
        public Diretor()
            : base("José", 35000.0, 16)
        {
        }
    }
}
