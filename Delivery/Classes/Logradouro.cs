using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Classes
{
    public class Logradouro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public TipoLogradouro Tipo { get; set; }
        public Cidade Cidade { get; set; }


        public Logradouro() { } 
    }
}
