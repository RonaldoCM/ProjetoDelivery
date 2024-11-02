using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Logradouro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public int IdTipo { get; set; }
        public int IdCidade { get; set; }


        public Logradouro(string nome, string numero, int tipo, int cidade) 
        {
            this.Nome = nome;
            this.Numero = numero;
            this.IdTipo = tipo;
            this.IdCidade = cidade;
        } 
    }
}
