using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class FabricaHonda: FabricaMontadora
    {
        public override Moto CriaMoto()
        {
            return new Titan();
        }
        public override Carro CriaCarro()
        {
            return new Fit();
        }
    }
}
