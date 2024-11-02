namespace Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public DateTime DataCriacao { get; set; }
        public decimal ValorFrete { get; set; }
        public decimal ValorTotal { get; set; }
        public int IdSituacao { get;  set; }
        public int IdPessoa { get; set; }
        public int IdLogradouro { get; set; }
        public List<ItensPedido> ItensPedido { get; set; }

        public Pedido(string codigo, DateTime dataCriacao, decimal valorFrete, decimal valorTotal, int idSituacao, int idPessoa, List<ItensPedido> itensPedido) 
        {
            Codigo = codigo;
            DataCriacao = dataCriacao; 
            ValorFrete = valorFrete;
            ValorTotal = valorTotal;
            IdSituacao = idSituacao;
            IdPessoa = idPessoa;
            ItensPedido = itensPedido;
            
        } 
    }
}
