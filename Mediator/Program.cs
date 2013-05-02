using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria sala01
            SalaDeBatePapo sala01 = new SalaDeBatePapo();
            // Cria e registra os participantes na sala
            Participante Jorge = new Homem("Jorge");
            Participante Paulo = new Homem("Paulo");
            Participante Tiago = new Homem("Tiago");
            Participante Marcos = new Homem("Marcos");
            Participante Ana = new Mulher("Ana");
            sala01.registra(Jorge);
            sala01.registra(Paulo);
            sala01.registra(Tiago);
            sala01.registra(Marcos);
            sala01.registra(Ana);
            // Participantes Batendo Papo
            Ana.envia("Marcos", "Olá Marcos!");
            Paulo.envia("Tiago", "E aí? Quais são as novidades?");
            Tiago.envia("Jorge", "Seu time é muito ruim!");
            Paulo.envia("Marcos", "Essa sala só tem uma mulher!!!");
            Marcos.envia("Ana", "Vamos sair hoje?");
        }
    }
}
