namespace Delivery.Classes
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set;}

        public Pessoa(string nome, string senha )
        {
            Nome = nome;
            Senha = senha;
        }
    }
}
