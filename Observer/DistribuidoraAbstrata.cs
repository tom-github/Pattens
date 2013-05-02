using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Observer
{
    abstract class DistribuidoraAbstrata
    {
        protected string nome;
        protected double preco;
        private ArrayList postos = new ArrayList();
        // Construtor
        public DistribuidoraAbstrata(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
        public void anexar(PostoDeGasolina posto)
        {
            postos.Add(posto);
        }
        public void desanexar(PostoDeGasolina posto)
        {
            postos.Remove(posto);
        }
        public void notificar()
        {
            foreach (PostoDeGasolina posto in postos)
            {
                posto.atualizar(this);
            }
            Console.WriteLine("");
        }
        // Propriedades
        public double PrecoLitroGasolina
        {
            get { return preco; }
            set
            {
                preco = value;
                notificar();
            }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
