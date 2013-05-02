using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Strategy
{
    class QuickSort: EstrategiaOrdenacao
    {
        public override void ordena(ArrayList lista)
        {
            lista.Sort(); // Padrão é Quicksort
            Console.WriteLine("Lista - QuickSort ");
        }
    }
}
