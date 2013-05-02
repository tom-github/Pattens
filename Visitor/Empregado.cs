using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class Empregado : Elemento
    {
        string nome;
        double salario;
        int diasFerias;
        // Construtor
        public Empregado(string nome, double salario, int diasFerias)
        {
            this.nome = nome;
            this.salario = salario;
            this.diasFerias = diasFerias;
        }
        // Propriedades
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public int DiasFerias
        {
            get { return diasFerias; }
            set { diasFerias = value; }
        }
        public override void aceita(IVisitante visitante)
        {
            visitante.visitar(this);
        }
    }
}
