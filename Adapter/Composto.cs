using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Composto
    {
        protected string nome;
        protected float pontoEbulicao;
        protected float pontoFusao;
        protected double pesoMolecular;
        protected string formulaMolecular;
        // Construtor
        public Composto(string nome)
        {
            this.nome = nome;
        }
        public virtual void mostra()
        {
            Console.WriteLine("\nComposto: {0} ------ ", nome);
        }
    }
}
