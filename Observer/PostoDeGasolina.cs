using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class PostoDeGasolina: IPosto 
    {
        private string nome;
        private Distribuidora distribuidora;
        // Construtor
        public PostoDeGasolina(string nome)
        {
        this.nome = nome;
        }
        public void atualizar(DistribuidoraAbstrata distribuidora)
        {
        Console.WriteLine("{0} notificado pela {1} a mudar o preco para {2:C}", nome, distribuidora.Nome, distribuidora.PrecoLitroGasolina);
        }
        // Propriedade
        public Distribuidora Distribuidora
        {
        get{ return distribuidora; }
        set{ distribuidora = value; }
        }
    }
}
