using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Classes
{
    public class SituacaoPedido
    {
        public int Id { get; set; } 
        public string Descricao { get; set; }

        public SituacaoPedido(string descricao) 
        { 
            Descricao = descricao;
        }
    }
}
