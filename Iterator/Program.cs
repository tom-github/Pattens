using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constrói a coleção
            Colecao colecao = new Colecao();
            colecao[0] = new Item("Item 0");
            colecao[1] = new Item("Item 1");
            colecao[2] = new Item("Item 2");
            colecao[3] = new Item("Item 3");
            colecao[4] = new Item("Item 4");
            colecao[5] = new Item("Item 5");
            colecao[6] = new Item("Item 6");
            colecao[7] = new Item("Item 7");
            colecao[8] = new Item("Item 8");

            // Cria Iterador
            Iterador iterador = new Iterador(colecao);
            // Pula todos os outros itens
            iterador.Passo = 2;
            Console.WriteLine("Iterando sobre colecao:");
            for (Item item = iterador.primeiro(); !iterador.EstaFeito;
            item = iterador.proximo())
            {
                Console.WriteLine(item.Nome);
            }
        }
    }
}
