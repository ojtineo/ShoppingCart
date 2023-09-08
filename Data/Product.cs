namespace ShoppingCart.Data
{

    public class Product
    {
        public Product(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal Price { get; set; }
    
    }
}
