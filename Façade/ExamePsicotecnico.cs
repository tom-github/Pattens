using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class ExamePsicotecnico
    {
        public bool possuiCondicoesMentais(Candidato c)
        {
            Console.WriteLine(c.Nome + " possui condições mentais");
            return true;
        }
    }
}
