using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Composite
{
    class ElementoComposto : Elemento
    {
        private ArrayList elementos = new ArrayList();
        // Construtor
        public ElementoComposto(string nome)
            : base(nome)
        {
        }
        public override void adiciona(Elemento d)
        {
            elementos.Add(d);
        }
        public override void remove(Elemento d)
        {
            elementos.Remove(d);
        }
        public override void mostra(int indentacao)
        {
            Console.WriteLine(new String('-', indentacao) + "+ " + nome);
            // mostra cada elemento filho neste nó
            foreach (Elemento e in elementos)
                e.mostra(indentacao + 2);
        }
    }
}
