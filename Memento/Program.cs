namespace Memento
{
    class Program
    {
        static void Main()
        {
            ProspectoVendas s = new ProspectoVendas
                {
                    Nome = "Marcos Paulo",
                    Telefone = "(031) 1234-5678",
                    Orcamento = 25000.0
                };

            // Salva estado interno
            MemoriaProspecto m = new MemoriaProspecto
                {
                    Recordacao = s.SalvaRecordacao()
                };

            // Continua modificando originador
            s.Nome = "Marques Corrêa";
            s.Telefone = "(031) 8765-4321";
            s.Orcamento = 100000.0;
            // Restaura estado salvo
            s.RestauraRecordacao(m.Recordacao);
        }
    }
}
