using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria o procuradorMatematico
            ProcuradorMatematico p = new ProcuradorMatematico();
            // Fas as Contas

            Console.WriteLine("4 + 2 = " + p.Adicao(4, 2));
            Console.WriteLine("4 - 2 = " + p.Subtracao(4, 2));
            Console.WriteLine("4 * 2 = " + p.Multiplicacao(4, 2));
            Console.WriteLine("4 / 2 = " + p.Divisao(4, 2));
        }
    }
}
