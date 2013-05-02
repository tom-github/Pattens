using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class PretensaoSalarial
    {
        public bool ehPossivel(Candidato c)
        {
            if (c.PretensaoSalarial > 7000 && c.PretensaoSalarial < 11000)
            {
                Console.WriteLine("Salário de " + c.Nome + " podeser pago");
                return true;
            }
            else
                return false;
        }
    }
}
