using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {

            // Cria uma estrutura de árvore
            ElementoComposto aviao = new ElementoComposto("Airbus A-319");
            aviao.adiciona(new ElementoPrimitivo("Fuselagem"));
            aviao.adiciona(new ElementoPrimitivo("Cauda"));
            aviao.adiciona(new ElementoPrimitivo("Nariz"));
            // Cria um nó não folha
            ElementoComposto asaDireita = new ElementoComposto("Asa Direita");
            asaDireita.adiciona(new ElementoPrimitivo("Motor Direito"));
            asaDireita.adiciona(new ElementoPrimitivo("Tanque Direito"));
            aviao.adiciona(asaDireita);
            // Cria outro nó não folha
            ElementoComposto asaEsquerda = new ElementoComposto("Asa Esquerda");
            asaEsquerda.adiciona(new ElementoPrimitivo("Motor Esquerdo"));
            asaEsquerda.adiciona(new ElementoPrimitivo("Tanque Esquerdo"));
            aviao.adiciona(asaEsquerda);
            // adiciona e remove um ElementoPrimitivo
            ElementoPrimitivo tremDePouso = new ElementoPrimitivo("Trem de Pouso");
            aviao.adiciona(tremDePouso);
            aviao.remove(tremDePouso);
            // mostra os nós recursivamente
            aviao.mostra(1);
        }
    }
}
