using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    abstract class Comando
    {
        public abstract void executar();
        public abstract void desfazerExecucao();
    }
}
