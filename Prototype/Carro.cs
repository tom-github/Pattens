using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    class Carro : CarroPrototipo
    {
        private string marca;
        private string modelo;
        private string cor;
        private int ano;
        private double preco;
        // Construtor
        public Carro(string marca, string modelo, string cor, int ano,
        double preco)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.ano = ano;
            this.preco = preco;
        }
        // Cria uma cópia superficial do Carro
        public override CarroPrototipo Clone()
        {
            Console.WriteLine("Clonando carro: {0}, {1}, {2}, {3},{4}", marca, modelo, cor, ano, preco);
            return this.MemberwiseClone() as CarroPrototipo;
        }
    }
}
