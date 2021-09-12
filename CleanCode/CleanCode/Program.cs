using System;

namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new CentralBankServiceAdapter());
            productService.Sell(new Product() { Id = 1, Name = "Laptop", Price = 1000 },
                new Officer() { Id = 1, Name = "Engin" });
        }
    }
}
