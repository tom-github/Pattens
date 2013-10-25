namespace Memento
{
    class Recordacao
    {
        private string nome;
        private string telefone;
        private double orcamento;
        // Construtor
        public Recordacao(string nome, string telefone, double
        orcamento)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.orcamento = orcamento;
        }
        // Propriedades
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }

        }
        public double Orcamento
        {
            get { return orcamento; }
            set { orcamento = value; }
        }
    }
}
