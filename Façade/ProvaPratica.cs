using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class ProvaPratica
    {
        public bool passou(Candidato c)
        {
            Console.WriteLine(c.Nome + " passou na prova prática");
            return true;
        }
    }
}
