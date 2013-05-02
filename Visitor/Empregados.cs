using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Visitor
{
    class Empregados
    {
        private ArrayList empregados = new ArrayList();
        public void anexa(Empregado empregado)
        {
            empregados.Add(empregado);
        }
        public void desanexa(Empregado empregado)
        {
            empregados.Remove(empregado);
        }
        public void aceita(IVisitante visitante)
        {
            foreach (Empregado e in empregados)
            {
                e.aceita(visitante);

            }
            Console.WriteLine();
        }
    }
}
