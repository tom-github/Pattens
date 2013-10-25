using System;
using System.Data;
using System.Data.OleDb;

namespace TemplateMethod
{
    class Clientes : DataAccessObject
    {
        public override void seleciona()
        {
            string sql = "SELECT nome FROM cliente";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, stringConexao);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "cliente");
        }
        public override void processa()
        {
            Console.WriteLine("Clientes ---- ");
            DataTable dataTable = dataSet.Tables["cliente"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["nome"]);
            }
            Console.WriteLine();
        }
    }
}
