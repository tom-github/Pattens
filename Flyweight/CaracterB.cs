using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    class CaracterB: Caracter
    {
        // Construtor
        public CaracterB()
        {
            this.simbolo = 'B';
            this.altura = 100;
            this.largura = 140;
            this.aclive = 72;
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
