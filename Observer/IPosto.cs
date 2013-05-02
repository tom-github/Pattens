using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    interface IPosto
    {
        void atualizar(DistribuidoraAbstrata distribuidora);
    }
}
