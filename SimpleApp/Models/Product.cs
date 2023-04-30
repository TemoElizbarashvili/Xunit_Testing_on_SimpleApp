namespace SimpleApp.Models
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public decimal? Price { get; set; }

        //public static Product[] GetProducts()
        //{
        //    Product Kayak = new Product
        //    {
        //        Name = "Kayak",
        //        Price = 275M
        //    };
        //    Product LifeJacket = new Product
        //    {
        //        Name = "LifeJacket",
        //        Price = 48.95M
        //    };
        //    return new Product[] { Kayak, LifeJacket };
        //}
    }
    public class ProductDataSource : IDataSource
    {
        public IEnumerable<Product> Products =>
            new Product[]
            {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M }
            };
    }
}
