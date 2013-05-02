using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_of_Responsability
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configura a Cadeia de Responsabilidade
            Diretor Jose = new Diretor();
            VicePresidente Silva = new VicePresidente();
            Presidente Correa = new Presidente();
            Jose.setSucessor(Silva);
            Silva.setSucessor(Correa);
            // Gera e processa as solicitações de Compra
            Compra p = new Compra(2034, 350.00, "Suprimentos");
            Jose.processarSolicitacao(p);
            p = new Compra(2035, 32590.10, "Projeto X");
            Jose.processarSolicitacao(p);
            p = new Compra(2036, 122100.00, "Projeto Y");
            Jose.processarSolicitacao(p);
        }
    }
}
