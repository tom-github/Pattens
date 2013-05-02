using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    class CaracterZ : Caracter
    {

        // Construtor
        public CaracterZ()
        {
            this.simbolo = 'Z';
            this.altura = 100;
            this.largura = 100;
            this.aclive = 68;
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
