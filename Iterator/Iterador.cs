using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class Iterador: IIteradorAbstrato
    {
        private Colecao colecao;
        private int atual = 0;
        private int passo = 1;
        // Construtor
        public Iterador(Colecao colecao)
        {
            this.colecao = colecao;
        }
        public Item primeiro()
        {
            atual = 0;
            return colecao[atual] as Item;
        }
        public Item proximo()
        {
            atual += passo;
            if (!EstaFeito)
                return colecao[atual] as Item;
            else
                return null;
        }
        // Propriedades
        public int Passo
        {
            get { return passo; }
            set { passo = value; }
        }
        public Item ItemAtual
        {
            get
            {
                return colecao[atual] as Item;
            }
        }
        public bool EstaFeito
        {
            get
            {
                return atual >= colecao.Contador ? true : false;
            }
        }
    }
}
