using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    abstract class Elemento
    {
        protected string nome;
        // Construtor
        public Elemento(string nome)
        {
            this.nome = nome;
        }
        public abstract void adiciona(Elemento d);
        public abstract void remove(Elemento d);
        public abstract void mostra(int indentacao);
    }
}
