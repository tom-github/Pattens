using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    class ExpressaoCentenas: Expressao
    {
        public override string Um() { return "C"; }
        public override string Quatro() { return "CD"; }
        public override string Cinco() { return "D"; }
        public override string Nove() { return "CM"; }
        public override int Multiplicador() { return 100; }
    }
}
