using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Decorator: ItemDaBiblioteca
    {
        protected ItemDaBiblioteca itemDaBiblioteca;
        // Construtor
        public Decorator(ItemDaBiblioteca itemDaBiblioteca)
        {
            this.itemDaBiblioteca = itemDaBiblioteca;
        }
        public override void Mostra()
        {
            itemDaBiblioteca.Mostra();
        }
    }
}
