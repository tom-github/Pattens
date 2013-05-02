using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Logging log1 = Logging.Instancia;
            log1.registros.Add("Instancia 1 de Logging!");
            Logging log2 = Logging.Instancia;
            log2.registros.Add("Instancia 2 de Logging!");
            Logging log3 = Logging.Instancia;
            log3.mostraRegistros();
        }

    }
}
