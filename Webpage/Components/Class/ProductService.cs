namespace Webpage.Components.Class
{
    public class ProductService
    {
        public List<Product> Products { get; private set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public class Product
        {
            public string Name { get; set; }
            public int IndexValue { get; set; }
            public int Price { get; set; }
            public int DiscountPrice { get; set; }
            public string ImageUrl { get; set; }
            public int Quantity { get; set; }
            public decimal DiscountPrecentage { get; set; }
        }
    }
}
