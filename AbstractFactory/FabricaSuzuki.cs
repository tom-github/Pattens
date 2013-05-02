using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class FabricaSuzuki : FabricaMontadora
    {
        public override Moto CriaMoto()
        {
            return new Katana();
        }
        public override Carro CriaCarro()
        {
            return new Vitara();
        }
    }
}

