namespace Delivery.Classes
{
    public class Bairro
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Cidade Cidade { get; set; }


        public Bairro() { }
    }
}
