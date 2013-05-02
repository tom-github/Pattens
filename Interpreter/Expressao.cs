using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    abstract class Expressao
    {
        public void interpretar(Conteudo conteudo)
        {
            if (conteudo.Entrada.Length == 0)
                return;
            if (conteudo.Entrada.StartsWith(Nove()))
            {
                conteudo.Saida += (9 * Multiplicador());
                conteudo.Entrada = conteudo.Entrada.Substring(2);
            }
            else if (conteudo.Entrada.StartsWith(Quatro()))
            {
                conteudo.Saida += (4 * Multiplicador());
                conteudo.Entrada = conteudo.Entrada.Substring(2);
            }
            else if (conteudo.Entrada.StartsWith(Cinco()))
            {
                conteudo.Saida += (5 * Multiplicador());
                conteudo.Entrada = conteudo.Entrada.Substring(1);
            }
            while (conteudo.Entrada.StartsWith(Um()))
            {
                conteudo.Saida += (1 * Multiplicador());
                conteudo.Entrada = conteudo.Entrada.Substring(1);
            }
        }
        public abstract string Um();
        public abstract string Quatro();
        public abstract string Cinco();
        public abstract string Nove();
        public abstract int Multiplicador();
    }
}

