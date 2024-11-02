using DataAccess;
using Model;
using System.Data;

namespace BusinessObjects
{
    public class ProdutoBO
    {
        private ProdutoDA _produtoDA;

        public ProdutoBO() 
        { 
            _produtoDA = new ProdutoDA();
        }

        public bool AdicionarProduto(Produto produto)
        {
            return _produtoDA.InsertProduto(produto);
        }


        public DataTable GetAllProdutos() 
        {
            var tableProdutos = _produtoDA.GetAllProduto();
            return tableProdutos;
        }

    }
}
