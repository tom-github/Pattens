using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class ComandoCalculadora : Comando
    {
        char operador;
        int operando;
        Calculadora calculadora;

        // Construtor
        public ComandoCalculadora(Calculadora calculadora, char operador, int operando)
        {
            this.calculadora = calculadora;
            this.operador = operador;
            this.operando = operando;
        }
        public char Operador
        {
            set { operador = value; }
        }

        public override void executar()
        {
            calculadora.Operacao(operador, operando);
        }

        public override void desfazerExecucao()
        {
            calculadora.Operacao(desfazer(operador), operando);
        }

        // Função de auxílio privada
        private char desfazer(char operador)
        {
            char desfazer;
            switch (operador)
            {
                case '+': desfazer = '-'; break;
                case '-': desfazer = '+'; break;
                case '*': desfazer = '/'; break;
                case '/': desfazer = '*'; break;
                default: desfazer = ' '; break;
            }
            return desfazer;
        }
    }
}
