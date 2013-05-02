using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria AbstracaoRefinada
            Selecao selecao = new Selecao("Brasil");
            // Seta ImplementadorConcreto
            selecao.Dados = new DadosSelecao();
            // Trabalha com a Ponte
            selecao.Mostra();
            selecao.Proximo();
            selecao.Mostra();
            selecao.Proximo();
            selecao.Mostra();
            selecao.Novo("Alex");
            selecao.MostraTodos();
        }
    }
}
