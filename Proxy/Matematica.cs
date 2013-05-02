using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    class Matematica: IMatematica
    {
        public double Adicao(double x, double y) { return x + y; }
        public double Subtracao(double x, double y) { return x - y; }
        public double Multiplicacao(double x, double y) { return x * y; }
        public double Divisao(double x, double y) { return x / y; }
    }
}
