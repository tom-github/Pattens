using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constrói um documento com texto
            string documento = "AAZZBBZB";
            char[] caracteres = documento.ToCharArray();
            FabricaCaracter f = new FabricaCaracter();
            // estado extrínseco
            int tamanho = 10;
            // Para cada caracter, usa um objeto pesopena
            foreach (char c in caracteres)
            {
                tamanho++;
                Caracter caracter = f.getCaracter(c);
                caracter.Mostra(tamanho);
            }
        }
    }
}
