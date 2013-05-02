using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    class Conteudo
    {
        private string entrada;
        private int saida;
        // Construtor
        public Conteudo(string entrada)
        {
            this.entrada = entrada;
        }
        // Propriedades
        public string Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }
        public int Saida
        {
            get { return saida; }
            set { saida = value; }
        }
    }
}
