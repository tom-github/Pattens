using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria Livro
            Livro livro = new Livro("E. Gamma", "Padrões de Projeto", 10);
            livro.Mostra();
            // Cria Video
            Video video = new Video("B. Gates", "Eu adoro C#", 23, 92);
            video.Mostra();
            // Faz o vídeo emprestável, depois empresta e mostra
            Console.WriteLine("\nEmprestando Vídeos:");
            Emprestavel emprestarVideo = new Emprestavel(video);
            emprestarVideo.EmprestarItem("Cliente nº 1");
            emprestarVideo.EmprestarItem("Cliente n° 2");
            emprestarVideo.Mostra();
        }
    }
}
