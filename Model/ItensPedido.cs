namespace Model
{
    public class ItensPedido
    {

        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

    }
}
