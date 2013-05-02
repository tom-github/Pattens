using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FactoryMethod
{
    abstract class Fabricante
    {
        private ArrayList carros = new ArrayList();
        // Construtor chama a Fábrica
        public Fabricante()
        {
            this.CriaCarros();
        }
        public ArrayList Carros
        {
            get { return carros; }
        }
        // Fábrica
        public abstract void CriaCarros();
    }
}
