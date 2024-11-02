using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class PedidoBO
    {

        private PedidoDA _pedidoDA;

        public PedidoBO()
        {
            _pedidoDA = new PedidoDA();
        }

        public bool AdicionarPedido(Pedido p)
        {
            if (string.IsNullOrWhiteSpace(p.Codigo))
            {
                throw new ArgumentException("O Código não pode ser vazio.");
            }
            
            var inserido = _pedidoDA.InsertPedido(p);

            return inserido;
        }

        public void DeletarPedido()
        { }

        public void BuscarPedido()
        { }

        public DataTable BuscarPedidoPorId(int pedidoId)
        {
            var table = _pedidoDA.GetPedido(pedidoId);

            return table;
        }
    }
}
