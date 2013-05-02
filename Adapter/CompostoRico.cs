using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class CompostoRico: Composto
    {
        private BaseDeDadosQuimica banco;
        // Construtor
        public CompostoRico(string nome)
            : base(nome)
        {
        }
        public override void mostra()
        {
            // Desejada
            banco = new BaseDeDadosQuimica();
            pontoEbulicao = banco.getPontoCritico(nome, "E");
            pontoFusao = banco.getPontoCritico(nome, "F");
            pesoMolecular = banco.getPesoMolecular(nome);
            formulaMolecular = banco.getEstruturaMolecular(nome);
            base.mostra();
            Console.WriteLine(" Fórmula: {0}", formulaMolecular);
            Console.WriteLine(" Peso : {0}", pesoMolecular);
            Console.WriteLine(" Pt. Ebuliçãot: {0}", pontoFusao);
            Console.WriteLine(" Pt. Fusão: {0}", pontoEbulicao);
        }
    }
}
