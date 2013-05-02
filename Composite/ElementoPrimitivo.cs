using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class ElementoPrimitivo : Elemento
    {
        // Construtor
        public ElementoPrimitivo(string nome)
            : base(nome)
        {
        }
        public override void adiciona(Elemento c)
        {
            Console.WriteLine("Não é possível adicionar a ElementoPrimitivo");
        }
        public override void remove(Elemento c)
        {
            Console.WriteLine("Não é possível remover de ElementoPrimitivo");
        }
        public override void mostra(int indentacao)
        {
            Console.WriteLine(new String('-', indentacao) + " " + nome);
        }
    }
}
