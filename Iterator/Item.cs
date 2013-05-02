using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class Item
    {
        string nome;
        // Construtor
        public Item(string nome)
        {
            this.nome = nome;
        }
        // Propriedade
        public string Nome
        {
            get { return nome; }
        }
    }
}
