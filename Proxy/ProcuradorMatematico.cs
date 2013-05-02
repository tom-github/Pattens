using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    class ProcuradorMatematico: IMatematica
    {
        Matematica matematica;
        public ProcuradorMatematico()
        {
            matematica = new Matematica();
        }
        public double Adicao(double x, double y)
        {
            return matematica.Adicao(x, y);
        }
        public double Subtracao(double x, double y)
        {
            return matematica.Subtracao(x, y);
        }
        public double Multiplicacao(double x, double y)
        {
            return matematica.Multiplicacao(x, y);
        }
        public double Divisao(double x, double y)
        {
            return matematica.Divisao(x, y);
        }
    }
}
