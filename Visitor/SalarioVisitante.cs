using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class SalarioVisitante : IVisitante
    {
        public void visitar(Elemento elemento)
        {
            Empregado empregado = elemento as Empregado;
            // Dá aumento de 10%
            empregado.Salario *= 1.10;
            Console.WriteLine("Novo salário do {0} {1}: {2:C}",
            empregado.GetType().Name, empregado.Nome, empregado.Salario);
        }
    }
}
