using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Decorator
{
    class Emprestavel : Decorator
    {
        protected ArrayList clientes = new ArrayList();
        // Construtor
        public Emprestavel(ItemDaBiblioteca itemDaBiblioteca)
            : base(itemDaBiblioteca)
        {
        }
        public void EmprestarItem(string nome)
        {
            clientes.Add(nome);
            itemDaBiblioteca.NumCopias--;
        }
        public void DevolverItem(string nome)
        {
            clientes.Remove(nome);
            itemDaBiblioteca.NumCopias++;
        }
        public override void Mostra()
        {
            base.Mostra();
            foreach (string cliente in clientes)
            {
                Console.WriteLine(" Cliente: " + cliente);

            }
        }
    }
}