using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccessObject dao;
            dao = new Clientes();
            dao.executa();
            dao = new Produtos();
            dao.executa();
        }
    }
}
