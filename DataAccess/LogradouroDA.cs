using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DataAccess
{
    public class LogradouroDA
    {
        MySqlDataAccess mySqlDataAccess = new MySqlDataAccess("localhost", "DLYDB", "root", "Rl1964071086@");

        private List<Logradouro> logradouros = new List<Logradouro>();

        
        public bool InsertLogradouro(Logradouro logradouro)
        {
            string query = "INSERT INTO LOGRADOURO (NOME, NUMERO, TIPOLOGRADOURO_ID, CIDADE_ID) VALUES (@nome, @numero, @tipologradouro_id, @cidade_id)";
            var parameters = new Dictionary<string, object>
            {
                { "@nome", logradouro.Nome },
                { "@numero", logradouro.Numero },
                { "@tipologradouro_id", logradouro.IdTipo },
                { "@cidade_id", logradouro.IdCidade }
            };

            return mySqlDataAccess.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetAllLogradouro()
        {
            string query = "SELECT * FROM LOGRADOURO";
            return mySqlDataAccess.ExecuteQuery(query);
        }

        public DataTable GetAllTipoLogradouro()
        {
            string query = "SELECT * FROM TIPOLOGRADOURO";
            return mySqlDataAccess.ExecuteQuery(query);
        }

    }
}
