using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    interface IIteradorAbstrato
    {
        Item primeiro();
        Item proximo();
        bool EstaFeito { get; }
        Item ItemAtual { get; }
    }
}
