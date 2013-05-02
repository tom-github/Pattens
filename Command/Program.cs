using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria o usuário e deixa ele computar
            Usuario usuario = new Usuario();
            usuario.computar('+', 100);
            usuario.computar('-', 50);
            usuario.computar('*', 10);
            usuario.computar('/', 2);
            // Desfaz 4 comandos
            usuario.desfazer(4);
            // Refaz 4 comandos
            usuario.refazer(3);
        }
    }
}
