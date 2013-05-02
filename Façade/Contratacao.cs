using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Contratacao
    {
        private ExameMedico exameMedico = new ExameMedico();
        private ExamePsicotecnico examePsicotecnico = new
        ExamePsicotecnico();

        private ProvaPratica provaPratica = new ProvaPratica();
        private PretensaoSalarial pretensaoSalarial = new PretensaoSalarial();

        //Verifica possibilidade de contratacao do candidato
        public bool seraContratado(Candidato c)
        {
            Console.WriteLine("Verificando contratacao de " + c.Nome);
            bool seraContratado = true;
            if (!exameMedico.possuiCondicoesFisicas(c))
                seraContratado = false;
            if (!examePsicotecnico.possuiCondicoesMentais(c))
                seraContratado = false;
            if (!provaPratica.passou(c))
                seraContratado = false;
            if (!pretensaoSalarial.ehPossivel(c))
                seraContratado = false;
            return seraContratado;
        }
    }
}
