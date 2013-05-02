using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    abstract class Caracter
    {
        protected char simbolo;
        protected int largura;
        protected int altura;
        protected int aclive;
        protected int declive;
        protected int tamanho;
        public abstract void Mostra(int tamanho);
    }
}
