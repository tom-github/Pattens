using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Video : ItemDaBiblioteca
    {
        private string diretor;
        private string titulo;
        private int duracao;
        // Construtor
        public Video(string diretor, string titulo,
        int numCopias, int duracao)
        {
            this.diretor = diretor;
            this.titulo = titulo;
            this.NumCopias = numCopias;
            this.duracao = duracao;
        }
        public override void Mostra()
        {
            Console.WriteLine("\nVídeo ----- ");
            Console.WriteLine(" Diretor: {0}", diretor);
            Console.WriteLine(" Title: {0}", titulo);
            Console.WriteLine(" Duração: {0}\n", duracao);
            Console.WriteLine(" # Copies: {0}", NumCopias);
        }
    }
}
