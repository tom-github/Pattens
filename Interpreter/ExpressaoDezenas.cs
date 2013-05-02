using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    class ExpressaoDezenas: Expressao
    {
        public override string Um() { return "X"; }
        public override string Quatro() { return "XL"; }
        public override string Cinco() { return "L"; }
        public override string Nove() { return "XC"; }
        public override int Multiplicador() { return 10; }
    }
}
