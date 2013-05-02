using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class Selecao : BaseJogadores
    {
        // Construtor
        public Selecao(string grupo)
            : base(grupo)
        {
        }
        public override void MostraTodos()
        {
            // Adiciona linhas separadoras
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.MostraTodos();
            Console.WriteLine("------------------------");
        }
    }
}
