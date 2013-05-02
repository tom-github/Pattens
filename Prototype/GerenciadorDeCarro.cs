using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Prototype
{
    class GerenciadorDeCarro
    {
        Hashtable carros = new Hashtable();

        // Indexador
        public CarroPrototipo this[string nome]
        {
            get
            {
                return carros[nome] as CarroPrototipo;
            }
            set
            {

                carros.Add(nome, value);
            }
        }
    }
}
