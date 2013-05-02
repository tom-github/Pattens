using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria o contenxo seguindo os ordenamentos
            ListaOrdenada registrosEstudante = new ListaOrdenada();
            registrosEstudante.adiciona("João");
            registrosEstudante.adiciona("José");
            registrosEstudante.adiciona("Maria");
            registrosEstudante.adiciona("Pedro");
            registrosEstudante.adiciona("Ana");
            registrosEstudante.setEstrategiaOrdenamento(new QuickSort());
            registrosEstudante.ordena();
            registrosEstudante.setEstrategiaOrdenamento(new ShellSort());
            // nao sera visto diferenca pois ShellSort nao foi implementado
            registrosEstudante.ordena();
            registrosEstudante.setEstrategiaOrdenamento(new MergeSort());
            // nao sera visto diferenca pois MergeSort nao foi implementado
            registrosEstudante.ordena();
        }
    }
}

