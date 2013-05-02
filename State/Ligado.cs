using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class Ligado : Estado
    {
        // Sobrecarga de Construtores
        public Ligado(Estado estado)
            : this(estado.Interruptor)
        {
        }
        public Ligado(Interruptor interruptor)
        {
            aceso = true;
            this.interruptor = interruptor;
        }
        public override void ligar()
        {
            aceso = true;
            ChecaModificacaoEstado();
        }
        public override void desligar()
        {
            aceso = false;
            ChecaModificacaoEstado();
        }
        private void ChecaModificacaoEstado()
        {
            if (aceso == false)
            {
                interruptor.Estado = new Desligado(this);
                Console.WriteLine("Desligando Interruptor");
            }
            else
                Console.WriteLine("Interruptor já ligado!");
        }
    }
}
