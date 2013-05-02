using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Iterator
{
    class Colecao: IColecaoAbstrata
    {
        private ArrayList itens = new ArrayList();
        public Iterador criaIterador()
        {
            return new Iterador(this);
        }
        // Propriedade
        public int Contador
        {
            get { return itens.Count; }
        }
        // Indexador
        public object this[int indice]
        {
            get { return itens[indice]; }
            set { itens.Add(value); }
        }
    }
}
