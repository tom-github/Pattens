using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            ProspectoVendas s = new ProspectoVendas();
            s.Nome = "Marcos Paulo";
            s.Telefone = "(031) 1234-5678";
            s.Orcamento = 25000.0;
            // Salva estado interno
            MemoriaProspecto m = new MemoriaProspecto();
            m.Recordacao = s.SalvaRecordacao();
            // Continua modificando originador
            s.Nome = "Marques Corrêa";
            s.Telefone = "(031) 8765-4321";
            s.Orcamento = 100000.0;
            // Restaura estado salvo
            s.RestauraRecordacao(m.Recordacao);
        }
    }
}
