using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Distribuidora: DistribuidoraAbstrata
    {
        // Construtor
        public Distribuidora(string nome, double preco) : base(nome,preco)
        {
        }
    }
}
    
