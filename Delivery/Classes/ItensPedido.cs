namespace Delivery.Classes
{
    public class ItensPedido
    {

        public int Id { get; set; }
        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; }
        public int Quantidade { get; set; }
        public string Valor { get; set; }


        public ItensPedido() { }

    }
}
