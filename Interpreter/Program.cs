using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string romano = "MCMXXVIII";
            Conteudo conteudo = new Conteudo(romano);
            // Constrói a árvore de análise gramatical
            ArrayList arvore = new ArrayList();
            arvore.Add(new ExpressaoMilhares());
            arvore.Add(new ExpressaoCentenas());
            arvore.Add(new ExpressaoDezenas());
            arvore.Add(new ExpressaoUnidades());
            // interpretar
            foreach (Expressao exp in arvore)
            {
                exp.interpretar(conteudo);
            }
            Console.WriteLine("{0} = {1}", romano, conteudo.Saida);
        }
    }
}
