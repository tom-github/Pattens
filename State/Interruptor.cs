using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class Interruptor
    {
        private Estado estado;

        // Construtor
        public Interruptor()
        {
            estado = new Desligado(this);
        }
        // Propriedades
        public bool Ligado
        {
            get { return estado.Aceso; }
        }
        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public void ligar()
        {
            estado.ligar();
        }
        public void desligar()
        {
            estado.desligar();
        }
    }
}
