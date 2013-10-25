using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nota: construtores chamam a Fábrica
            Fabricante[] fabricantes = new Fabricante[2];
            fabricantes[0] = new Volkswagen();
            fabricantes[1] = new Fiat();

            // Mostra carros dos Fabricantes
            foreach (Fabricante fabricante in fabricantes)
            {
                Console.WriteLine("\n" + fabricante.GetType().Name +
                "--");
                foreach (Carro carro in fabricante.Carros)
                {
                    Console.WriteLine(" " +
                    carro.GetType().Name);
                }
            }
        }

    }
}
