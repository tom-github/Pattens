using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Flyweight
{
    class FabricaCaracter
    {
        private Hashtable caracteres = new Hashtable();
        public Caracter getCaracter(char chave)
        {
            Caracter caracter = caracteres[chave] as Caracter;
            if (caracter == null)
            {
                switch (chave)
                {
                    case 'A': caracter = new CaracterA(); break;
                    case 'B': caracter = new CaracterB(); break;
                    //...
                    case 'Z': caracter = new CaracterZ(); break;
                }
                caracteres.Add(chave, caracter);
            }
            return caracter;
        }
    }
}
