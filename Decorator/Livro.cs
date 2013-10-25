using System;

namespace Decorator
{
    class Livro: ItemDaBiblioteca
    {
        private string autor;
        private string titulo;
        // Construtor
        public Livro(string autor, string titulo, int numCopias)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.NumCopias = numCopias;
        }
        public override void Mostra()
        {
            Console.WriteLine("\nLivro ------ ");
            Console.WriteLine(" Autor: {0}", autor);
            Console.WriteLine(" Título: {0}", titulo);
            Console.WriteLine(" N° Cópias: {0}", NumCopias);
        }
    }
}
