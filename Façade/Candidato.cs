using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Candidato
    {
        private string nome;
        private double pretensaoSalarial;

        public Candidato(string nome, double pretensaoSalarial)
        {
        this.nome = nome;
        this.pretensaoSalarial = pretensaoSalarial;
        }
        public string Nome
        {
        get{ return nome;}
        }
        public double PretensaoSalarial
        {
        get{ return pretensaoSalarial;}
        }
    }
}
