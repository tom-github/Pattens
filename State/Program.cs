using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Interruptor interruptor = new Interruptor();
            //Liga e desliga o interruptor
            interruptor.ligar();
            interruptor.desligar();
            interruptor.desligar();
            interruptor.ligar();
            interruptor.ligar();
            interruptor.desligar();
        }
    }
}
