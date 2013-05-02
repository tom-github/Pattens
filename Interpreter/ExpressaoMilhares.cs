using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    class ExpressaoMilhares: Expressao
    {
        public override string Um() { return "M"; }
        public override string Quatro() { return " "; }
        public override string Cinco() { return " "; }
        public override string Nove() { return " "; }
        public override int Multiplicador() { return 1000; }
    }
}
