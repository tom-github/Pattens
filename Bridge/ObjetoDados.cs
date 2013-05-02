using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    abstract class ObjetoDados
    {
        public abstract void ProximoRegistro();
        public abstract void RegistroAnterior();
        public abstract void NovoRegistro(string nome);
        public abstract void ExcluiRegistro(string nome);
        public abstract void MostraRegistro();
        public abstract void MostraTodosRegistros();
    }
}
