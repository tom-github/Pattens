using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Calculadora
    {
        private int atual = 0;
        public void Operacao(char operador, int operando)
        {
            switch (operador)
            {
                case '+': atual += operando; break;
                case '-': atual -= operando; break;
                case '*': atual *= operando; break;
                case '/': atual /= operando; break;
            }
            Console.WriteLine("Valor atual = {0,3} (executado {1}{2})",
            atual, operador, operando);
        }
    }
}
