using DataAccess;
using System.Data;

namespace BusinessObjects
{
    public class CidadeBO
    {
        private CidadeDA _cidadeDA;

        public CidadeBO()
        {
            _cidadeDA = new CidadeDA();
        }

        public DataTable GetAllCidades()
        {
            var tableCidades = _cidadeDA.GetAllCidades();
            return tableCidades;
        }
    }
}
