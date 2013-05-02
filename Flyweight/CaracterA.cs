using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    class CaracterA: Caracter
    {
        // Construtor
        public CaracterA()
        {
            this.simbolo = 'A';
            this.altura = 100;
            this.largura = 120;
            this.aclive = 70;
            this.declive = 0;
        }
        public override void Mostra(int tamanho)
        {
            this.tamanho = tamanho;
            Console.WriteLine(this.simbolo + " (tamanho " +
            this.tamanho + ")");
        }
    }
}
