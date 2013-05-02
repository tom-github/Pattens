using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    abstract class FabricaMontadora
    {
        public abstract Moto CriaMoto();
        public abstract Carro CriaCarro();
    }
}
