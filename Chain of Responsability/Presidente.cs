using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_of_Responsability
{
    class Presidente : Aprovador
    {
        public override void processarSolicitacao(Compra compra)
        {
            if (compra.Quantia < 100000.0)
            {
                Console.WriteLine("{0} aprovou solicitação # {1}",
                this.GetType().Name, compra.Numero);
            }
            else
            {
                Console.WriteLine("Solicitação #{0} necessita de uma reunião dos executivos!", compra.Numero);
            }
        }
    }
}
