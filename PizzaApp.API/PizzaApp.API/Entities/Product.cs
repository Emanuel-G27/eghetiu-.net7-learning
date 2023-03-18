namespace PizzaApp.API.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductType Type { get; set; }

        public string Users { get; set; }
    }
    public enum ProductType
    {
        Pizza = 1,
        Juice = 2,
        Beer = 3
    };
}
             