using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DataAccess
{
    public class CidadeDA
    {
        MySqlDataAccess mySqlDataAccess = new MySqlDataAccess("localhost", "DLYDB", "root", "Rl1964071086@");

        public DataTable GetAllCidades()
        {
            string query = "SELECT * FROM CIDADE";
            return mySqlDataAccess.ExecuteQuery(query);
        }
    }
}
