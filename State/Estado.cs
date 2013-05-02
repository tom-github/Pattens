using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
   abstract class Estado
    {
        protected Interruptor interruptor;
        protected bool aceso;
        // Propriedades
        public Interruptor Interruptor
        {
            get { return interruptor; }
            set { interruptor = value; }
        }
        public bool Aceso
        {
            get { return aceso; }
            set { aceso = value; }
        }
        public abstract void ligar();
        public abstract void desligar();
    }
}
