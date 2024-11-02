using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccess;
using System.Data;

namespace BusinessObjects
{
    public class LogradouroBO
    {
        private LogradouroDA _logradouroDA;


        public LogradouroBO()
        {
            _logradouroDA = new LogradouroDA();
        }

        public bool AdicionarLogradouro(Logradouro l)
        {
            if (string.IsNullOrWhiteSpace(l.Nome))
            {
                throw new ArgumentException("O Nome não pode ser vazio.");
            }
            
            var inserido = _logradouroDA.InsertLogradouro(l);

            return inserido;
        }

        public DataTable ListarLogradouro()
        {
            return _logradouroDA.GetAllLogradouro();
        }

        public DataTable ListarTipoLogradouro()
        {
            return _logradouroDA.GetAllTipoLogradouro();
        }
    }
}
