using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class MemoriaProspecto
    {
        private Recordacao recordacao;
        // Propriedade
        public Recordacao Recordacao
        {
            set { recordacao = value; }
            get { return recordacao; }
        }
    }
}
