using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    public interface IMatematica
    {
        double Adicao(double x, double y);
        double Subtracao(double x, double y);
        double Multiplicacao(double x, double y);
        double Divisao(double x, double y);
    }
}
