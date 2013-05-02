using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            // Cria a FabricaHonda com seus respectivos automóveis
            FabricaHonda honda = new FabricaHonda();
            Automoveis auto = new Automoveis(honda);
            // Cria a FabricaSuzuki com seus respectivos automóveis
            FabricaSuzuki suzuki = new FabricaSuzuki();
            auto = new Automoveis(suzuki);
        }

    }
}
