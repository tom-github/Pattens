using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Composto Químico não-adaptado
            Composto material = new Composto("Desconhecido");
            material.mostra();
            // Composto Químico adaptado
            Composto agua = new CompostoRico("Água");
            agua.mostra();
            Composto benzina = new CompostoRico("Benzina");
            benzina.mostra();
            Composto alcool = new CompostoRico("Álcool");
            alcool.mostra();
        }
    }
}
