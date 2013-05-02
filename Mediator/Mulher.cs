using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Mulher: Participante
    {
        // Construtor
        public Mulher(string nome)
            : base(nome)
        {
        }
        public override void recebe(string de, string mensagem)
        {
            Console.Write("Para uma Mulher: ");
            base.recebe(de, mensagem);
        }
    }
}
