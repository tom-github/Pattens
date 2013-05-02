using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class Fiat: Fabricante
    {
        // Implementação da Fábrica
        public override void CriaCarros()
        {
            Carros.Add(new Marea());
            Carros.Add(new Idea());
        }
    }
}
