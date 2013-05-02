using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Homem: Participante
    {
        // Construtor
        public Homem(string nome)
            : base(nome)
        {
        }
        public override void recebe(string de, string mensagem)
        {
            Console.Write("Para um Homem: ");
            base.recebe(de, mensagem);
        }
    }
}
