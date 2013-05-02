using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class Desligado: Estado
    {
        // Sobrecarga de Construtores
        public Desligado(Estado estado)
            : this(estado.Interruptor)
        {
        }
        public Desligado(Interruptor interruptor)
        {
            aceso = false;
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
            if (aceso == true)
            {
                interruptor.Estado = new Ligado(interruptor);
                Console.WriteLine("Ligando Interruptor");
            }
            else
                Console.WriteLine("Interruptor já desligado!");
        }
    }
}
