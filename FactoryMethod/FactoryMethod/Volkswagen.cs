using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class Volkswagen: Fabricante
    {
        // Implementação da Fábrica
        public override void CriaCarros()
        {
            Carros.Add(new Golf());
            Carros.Add(new Polo());
        }
    }
}
