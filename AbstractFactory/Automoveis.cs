using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Automoveis
    {
        private Moto moto;
        private Carro carro;
        public Automoveis(FabricaMontadora fabrica)
        {
            moto = fabrica.CriaMoto();
            carro = fabrica.CriaCarro();
        }
    }
}
