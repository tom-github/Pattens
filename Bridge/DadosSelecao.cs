using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Bridge
{
    class DadosSelecao: ObjetoDados
    {
        private ArrayList selecao = new ArrayList();
        private int atual = 0;
        public DadosSelecao()
        {
            // Carregados de um banco de Dados
            selecao.Add("Ronaldinho");
            selecao.Add("Ronaldo");
            selecao.Add("Robinho");
            selecao.Add("Cacá");
            selecao.Add("Adriano");
        }
        public override void ProximoRegistro()
        {
            if (atual <= selecao.Count - 1)
                atual++;
        }
        public override void RegistroAnterior()
        {
            if (atual > 0)
                atual--;
        }
        public override void NovoRegistro(string nome)
        {
            selecao.Add(nome);
        }
        public override void ExcluiRegistro(string nome)
        {
            selecao.Remove(nome);
        }
        public override void MostraRegistro()
        {
            Console.WriteLine(selecao[atual]);
        }
        public override void MostraTodosRegistros()
        {
            foreach (string nome in selecao)
                Console.WriteLine(" " + nome);
        }
    }
}
