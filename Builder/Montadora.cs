using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Montadora
    {
        // Construtor usa uma série complexa de passos
        public void Construir(ConstrutorVeiculo construtorVeiculo)
        {
            construtorVeiculo.ConstruirChassi();
            construtorVeiculo.ConstruirMotor();
            construtorVeiculo.ConstruirRodas();
            construtorVeiculo.ConstruirPortas();
        }
    }
}
