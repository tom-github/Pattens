using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    class ExpressaoUnidades: Expressao
    {
        public override string Um() { return "I"; }
        public override string Quatro() { return "IV"; }
        public override string Cinco() { return "V"; }
        public override string Nove() { return "IX"; }
        public override int Multiplicador() { return 1; }
    }
}
