using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TemplateMethod
{
    abstract class DataAccessObject
    {
        protected string stringConexao;
        protected DataSet dataSet;
        public virtual void conecta()
        {
            // Tenha certeza que o caminho do banco está correto
            stringConexao = "provider=Microsoft.JET.OLEDB.4.0; data source=c:\\cadastros.mdb";
        }
        public abstract void seleciona();
        public abstract void processa();
        public virtual void disconecta()
        {
            stringConexao = "";
        }
        // O "Método Gabarito"
        public void executa()
        {
            conecta();
            seleciona();
            processa();
            disconecta();
        }
    }
}
