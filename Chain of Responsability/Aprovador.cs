using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_of_Responsability
{
    abstract class Aprovador
    {
        protected Aprovador successor;
        public void setSucessor(Aprovador successor)
        {
            this.successor = successor;
        }
        public abstract void processarSolicitacao(Compra compra);
    }
}
