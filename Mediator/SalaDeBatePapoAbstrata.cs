using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    abstract class SalaDeBatePapoAbstrata
    {
        public abstract void registra(Participante participante);
        public abstract void envia(string de, string para, string
        mensagem);
    }
}
