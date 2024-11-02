namespace Delivery.Classes
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }

        public Produto(string nome, decimal preco, string descricao ) 
        { 
            Nome = nome;
            Preco = preco;
            Descricao = descricao;            
        
        }

    }
}
