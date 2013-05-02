using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class BaseJogadores
    {
        private ObjetoDados objetoDados;
        protected string grupo;
        public BaseJogadores(string grupo)
        {
            this.grupo = grupo;
        }
        // Propriedade
        public ObjetoDados Dados
        {
            set { objetoDados = value; }
            get { return objetoDados; }
        }
        public virtual void Proximo()
        {
            objetoDados.ProximoRegistro();
        }
        public virtual void Anterior()
        {
            objetoDados.RegistroAnterior();
        }
        public virtual void Novo(string nome)
        {
            objetoDados.NovoRegistro(nome);
        }
        public virtual void Excluir(string nome)
        {
            objetoDados.ExcluiRegistro(nome);
        }
        public virtual void Mostra()
        {
            objetoDados.MostraRegistro();
        }
        public virtual void MostraTodos()
        {
            Console.WriteLine("Grupo de Jogadores: " + grupo);
            objetoDados.MostraTodosRegistros();
        }
    }
}
