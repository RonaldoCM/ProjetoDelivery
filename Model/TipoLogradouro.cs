using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TipoLogradouro
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public TipoLogradouro(string descricao) 
        {
            Descricao = descricao;
        }
    }
}
