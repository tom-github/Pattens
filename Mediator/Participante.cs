using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Participante
    {
        private SalaDeBatePapo sala01;
        private string nome;
        // Construtor
        public Participante(string nome)
        {
            this.nome = nome;
        }
        // Propriedades
        public string Nome
        {
            get { return nome; }
        }
        public SalaDeBatePapo SalaDeBatePapo
        {
            set { sala01 = value; }
            get { return sala01; }
        }
        // Métodos
        public void envia(string para, string mensagem)
        {
            sala01.envia(nome, para, mensagem);
        }
        public virtual void recebe(string de, string mensagem)
        {
            Console.WriteLine("{0} para {1}: '{2}'", de, Nome, mensagem);
        }
    }
}
