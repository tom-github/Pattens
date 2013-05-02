using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class ExameMedico
    {
        public bool possuiCondicoesFisicas(Candidato c)
        {
            Console.WriteLine(c.Nome + " possui condições físicas");
            return true;
        }
    }
}
