using Model;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class PessoaDA
    {
        MySqlDataAccess mySqlDataAccess = new MySqlDataAccess("localhost", "DLYDB", "root", "Rl1964071086@");

        private List<Pessoa> pessoas = new List<Pessoa>();

        public void AddPessoa(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
        }

        public List<Pessoa> GetPessoas()
        {
            return pessoas;
        }


        // Example method to insert data into a table
        public int InsertPerson(Pessoa p)
        {
            string query = "INSERT INTO PESSOA (NOME, SENHA) VALUES (@nome, @senha); SELECT LAST_INSERT_ID();";
            var parameters = new Dictionary<string, object>
            {
                { "@nome", p.Nome },
                { "@senha", p.Senha }
            };

            var id = mySqlDataAccess.ExecuteScalar(query, parameters);

            return id;
        }

        // Example method to retrieve all data from the 'PESSOA' table
        public DataTable GetAllPeople()
        {
            string query = "SELECT * FROM PESSOA";
            return mySqlDataAccess.ExecuteQuery(query);
        }

        // Example method to update a person's name
        public bool UpdatePersonName(int id, string newName)
        {
            string query = "UPDATE PESSOA SET NOME = @nome WHERE ID = @id";
            var parameters = new Dictionary<string, object>
            {
                { "@nome", newName },
                { "@id", id }
            };
            return mySqlDataAccess.ExecuteNonQuery(query, parameters);
        }

        // Example method to delete a person by ID
        public bool DeletePerson(int id)
        {
            string query = "DELETE FROM PESSOA WHERE ID = @id";
            var parameters = new Dictionary<string, object>
            {
                { "@id", id }
            };
            return mySqlDataAccess.ExecuteNonQuery(query, parameters);
        }

        public bool ValidarPessoa(Pessoa pessoa)
        {
            bool result = false;

            string query = "SELECT * FROM PESSOA WHERE NOME = @nome AND SENHA = @senha";

            var parameters = new Dictionary<string, object>
            {
                { "@nome", pessoa.Nome },
                { "@senha", pessoa.Senha }
            };

            var table = mySqlDataAccess.ExecuteQuery(query, parameters);

            result = table.Rows.Count == 1;

            return result;
        }
    }
}
