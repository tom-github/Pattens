using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class FeriasVisitante: IVisitante
    {
        public void visitar(Elemento elemento)
        {
            Empregado empregado = elemento as Empregado;
            // Dá 3 dias Extras de Férias
            empregado.DiasFerias += 3;
            Console.WriteLine("Novos dias de férias do {0} {1}: {2}",
            empregado.GetType().Name, empregado.Nome, empregado.DiasFerias);
        }
    }
}
