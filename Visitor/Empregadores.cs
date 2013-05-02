using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Visitor
{
    class Empregadores
    {
        private ArrayList empregados = new ArrayList();
        public void anexa(Empregados empregado)
        {
            empregados.Add(empregado);
        }
        public void desanexa(Empregados empregado)
        {
            empregados.Remove(empregado);
        }
        public void aceita(IVisitante visitante)
        {
            foreach (Empregados e in empregados)
            {
                e.aceita(visitante);
            }
            Console.WriteLine();
        }
    }
}
