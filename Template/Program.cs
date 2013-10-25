namespace TemplateMethod
{
    class Program
    {
        static void Main()
        {
            DataAccessObject dao;
            dao = new Clientes();
            dao.executa();
            dao = new Produtos();
            dao.executa();
        }
    }
}
