using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configura coleção de empregados
            Empregados e = new Empregados();
            e.anexa(new Secretario());
            e.anexa(new Diretor());
            e.anexa(new Presidente());
            // Empregados sao 'visitados'
            e.aceita(new SalarioVisitante());
            e.aceita(new FeriasVisitante());
        }
    }
}
