namespace Delivery.Classes
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public DateTime DataCriacao { get; set; }
        public decimal ValorFrete { get; set; }
        public decimal ValorTotal { get; set; }
        public SituacaoPedido Situacao { get;  set; }
        public Pessoa Pessoa { get; set; }

        public Pedido() { } 
    }
}
