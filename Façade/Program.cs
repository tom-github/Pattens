using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fachada
            Contratacao contratacao = new Contratacao();
            //Avalia a possibilidade de Contratacao do Candidato
            Candidato candidato = new Candidato("Marcos Paulo", 10000);
            bool contratar = contratacao.seraContratado(candidato);
            Console.WriteLine("\n" + candidato.Nome + (contratar ? "" : "Não") + " será contratado!");
        }
    }
}
