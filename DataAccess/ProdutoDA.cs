using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProdutoDA
    {
        MySqlDataAccess mySqlDataAccess = new MySqlDataAccess("localhost", "DLYDB", "root", "Rl1964071086@");


        public bool InsertProduto(Produto produto)
        {
            string query = "INSERT INTO PRODUTO (NOME, PRECO, DESCRICAO) VALUES (@nome, @preco, @Descricao)";
            var parameters = new Dictionary<string, object>
            {
                { "@nome", produto.Nome },
                { "@preco", produto.Preco },
                { "@descricao", produto.Descricao }
            };
            return mySqlDataAccess.ExecuteNonQuery(query, parameters);
        }
        
        public DataTable GetAllProduto()
        {
            string query = "SELECT * FROM PRODUTO";
            return mySqlDataAccess.ExecuteQuery(query);
        }

        public bool UpdateProduto(int id, string newNomeProduto)
        {
            string query = "UPDATE PRODUTO SET NOME = @nome WHERE ID = @id";
            var parameters = new Dictionary<string, object>
            {
                { "@nome", newNomeProduto },
                { "@id", id }
            };
            return mySqlDataAccess.ExecuteNonQuery(query, parameters);
        }
        
        public bool DeleteProduto(int id)
        {
            string query = "DELETE FROM PRODUTO WHERE ID = @id";
            var parameters = new Dictionary<string, object>
            {
                { "@id", id }
            };
            return mySqlDataAccess.ExecuteNonQuery(query, parameters);
        }

    }
}
