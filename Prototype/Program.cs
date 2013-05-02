using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeCarro gerenciador = new GerenciadorDeCarro();
            // Inicializa com carros padrões
            gerenciador["idea"] = new Carro("Fiat", "Idea", "laranja", 2006, 40000.00);
            gerenciador["golf"] = new Carro("VW", "Golf", "preto", 2005, 35000.00);
            gerenciador["astra"] = new Carro("Chevrolet", "Astra", "prata", 2003, 30000.00);

            Carro carro;
            // Usuario usa carros padrões
            string nome = "idea";
            carro = gerenciador[nome].Clone() as Carro;
            nome = "golf";
            carro = gerenciador[nome].Clone() as Carro;
            nome = "astra";
            carro = gerenciador[nome].Clone() as Carro;
        }
    }
}

