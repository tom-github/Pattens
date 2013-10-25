using System;

namespace Memento
{
    class ProspectoVendas
    {
        private string nome;
        private string telefone;
        private double orcamento;
        // Propriedades
        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
                Console.WriteLine("Nome: " + nome);

            }
        }

        public string Telefone
        {
            get { return telefone; }
            set
            {
                telefone = value;
                Console.WriteLine("Telefone: " + telefone);
            }
        }
        public double Orcamento
        {
            get { return orcamento; }
            set
            {
                orcamento = value;
                Console.WriteLine("Orcamento: " + orcamento);
            }
        }

        public Recordacao SalvaRecordacao()
        {
            Console.WriteLine("\nSalvando Estado --\n");
            return new Recordacao(nome, telefone, orcamento);
        }
        public void RestauraRecordacao(Recordacao recordacao)
        {
            Console.WriteLine("\nRestaurando Estado --\n");
            this.Nome = recordacao.Nome;
            this.Telefone = recordacao.Telefone;
            this.Orcamento = recordacao.Orcamento;
        }
    }
}
