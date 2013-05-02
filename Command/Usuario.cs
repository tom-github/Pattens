using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Command
{
    class Usuario
    {
        // Inicializadores
        private Calculadora calculadora = new Calculadora();
        private ArrayList comandos = new ArrayList();
        private int atual = 0;
        public void refazer(int niveis)
        {
            Console.WriteLine("\n---- refazer {0} niveis ", niveis);
            // Realiza operacoes refazer
            for (int i = 0; i < niveis; i++)
            {
                if (atual < comandos.Count - 1)
                {
                    Comando comando = comandos[atual++] as
                    Comando;
                    comando.executar();
                }
            }
        }
        public void desfazer(int niveis)
        {
            Console.WriteLine("\n---- desfazer {0} niveis ", niveis);
            // Realiza operacoes desfazer
            for (int i = 0; i < niveis; i++)
            {
                if (atual > 0)
                {
                    Comando comando = comandos[--atual] as
                    Comando;
                    comando.desfazerExecucao();
                }
            }
        }
        public void computar(char operador, int operando)
        {

            // Cria a operacao do comando e executa-a
            Comando comando = new ComandoCalculadora(calculadora,
            operador, operando);
            comando.executar();
            // Adiciona comando à lista desfazer
            comandos.Add(comando);
            atual++;
        }
    }
}