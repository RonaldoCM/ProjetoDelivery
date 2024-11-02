using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PedidoDA
    {

        MySqlDataAccess mySqlDataAccess = new MySqlDataAccess("localhost", "DLYDB", "root", "Rl1964071086@");

        public bool InsertPedido(Pedido p)
        {
            bool pedidoInserido, itensInserido = false;

            string query = "INSERT INTO PEDIDO (CODIGO, DATACRIACAO, VALORFRETE, VALORTOTAL, SITUACAOPEDIDO_ID, PESSOA_ID, LOGRADOURO_ID) " +
                                        "VALUES (@codigo, @datacriacao, @valorfrete, @valortotal, @situacaoid, @pessoaid, @logradouroid )";
            var parameters = new Dictionary<string, object>
            {
                { "@codigo", p.Codigo },
                { "@datacriacao", p.DataCriacao },
                { "@valorfrete", p.ValorFrete },
                { "@valortotal", p.ValorTotal },
                { "@situacaoid", p.IdSituacao },
                { "@pessoaid", p.IdPessoa },
                { "@logradouroid", p.IdLogradouro},

            };


            pedidoInserido = mySqlDataAccess.ExecuteNonQuery(query, parameters);

            if (pedidoInserido)
            {
                string queryItens = "INSERT INTO ITENSPEDIDO (VALOR, QUANTIDADE, PEDIDO_ID, PRODUTO_ID) VALUES (@PrecoUnitario, @Quantidade, @IdPedido, @IdProduto)";



                var parametersItens = new Dictionary<string, object>
            {
                { "@IdProduto", p.ItensPedido[0].IdProduto },
                { "@IdPedido", p.ItensPedido[0].IdPedido },
                { "@Quantidade", p.ItensPedido[0].Quantidade },
                { "@PrecoUnitario", p.ItensPedido[0].PrecoUnitario },

            };


                itensInserido = mySqlDataAccess.ExecuteNonQuery(queryItens, parametersItens);

            }

            bool resultado = false;

            if (pedidoInserido == itensInserido)
                resultado = true;

            return resultado;

        }

        public void DeletarPedido()
        { }

        public DataTable GetPedido(int pedidoId)
        {

            string query = "SELECT * FROM PEDIDO WHERE ID = @id";
            var parameters = new Dictionary<string, object>
            {
                { "@id", pedidoId }
            };

            var tablePedido =  mySqlDataAccess.ExecuteQuery(query, parameters);

            return tablePedido;
        }

        public DataTable GetAllPedido()
        {
            string query = "SELECT * FROM LOGRADOURO";
            return mySqlDataAccess.ExecuteQuery(query);
        }
    }
}
