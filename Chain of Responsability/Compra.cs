using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chain_of_Responsability
{
    class Compra
    {
        private int numero;
        private double quantia;
        private string finalidade;
        // Construtor
        public Compra(int numero, double quantia, string finalidade)
        {
            this.numero = numero;
            this.quantia = quantia;
            this.finalidade = finalidade;
        }
        // Propriedades
        public double Quantia
        {
            get { return quantia; }
            set { quantia = value; }
        }
        public string Finalidade
        {
            get { return finalidade; }
            set { finalidade = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
    }
}
