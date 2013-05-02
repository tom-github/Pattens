using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    abstract class ItemDaBiblioteca
    {
        private int numCopias;
        // Propriedade
        public int NumCopias
        {
            get { return numCopias; }
            set { numCopias = value; }
        }
        public abstract void Mostra();
    }
}
