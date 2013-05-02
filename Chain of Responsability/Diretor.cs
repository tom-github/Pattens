using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_of_Responsability
{
    class Diretor: Aprovador
    {
        public override void processarSolicitacao(Compra compra)
        {
            if (compra.Quantia < 10000.0)
            {
                Console.WriteLine("{0} aprovou solicitação # {1}",
                this.GetType().Name, compra.Numero);
            }
            else if (successor != null)
            {
                successor.processarSolicitacao(compra);
            }
        }
    }
}
