using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace TemplateMethod
{
    class Produtos: DataAccessObject
    {
        public override void seleciona()
        {
            string sql = "SELECT descricao FROM produto";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql,
            stringConexao);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "produto");
        }
        public override void processa()
        {
            Console.WriteLine("Produtos ---- ");
            DataTable dataTable = dataSet.Tables["produto"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["descricao"]);
            }
            Console.WriteLine();
        }
    }
}
