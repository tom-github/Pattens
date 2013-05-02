using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Mediator
{
    class SalaDeBatePapo : SalaDeBatePapoAbstrata
    {
        private Hashtable participantes = new Hashtable();
        public override void registra(Participante participante)
        {
            if (participantes[participante.Nome] == null)
                participantes[participante.Nome] = participante;
            participante.SalaDeBatePapo = this;
        }
        public override void envia(string de, string para, string mensagem)
        {
            Participante pto = (Participante)participantes[para];
            if (pto != null)
                pto.recebe(de, mensagem);
        }
    }
}
