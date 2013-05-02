using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    abstract class ConstrutorVeiculo
    {
        protected Veiculo veiculo;
        // Propriedade
        public Veiculo Veiculo
        {
            get { return veiculo; }
        }
        public abstract void ConstruirChassi();
        public abstract void ConstruirMotor();
        public abstract void ConstruirRodas();
        public abstract void ConstruirPortas();
    }
}
