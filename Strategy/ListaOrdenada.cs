using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Strategy
{
    class ListaOrdenada
    {
        private ArrayList lista = new ArrayList();
        private EstrategiaOrdenacao estrategiaOrdenacao;
        public void setEstrategiaOrdenamento(EstrategiaOrdenacao estrategiaOrdenacao)
        {
            this.estrategiaOrdenacao = estrategiaOrdenacao;
        }
        public void adiciona(string nome)
        {
            lista.Add(nome);
        }
        public void ordena()
        {
            estrategiaOrdenacao.ordena(lista);
            // Mostra resultados
            foreach (string nome in lista)
            {
                Console.WriteLine(" " + nome);

            }
            Console.WriteLine();
        }
    }
}
