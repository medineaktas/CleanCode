using System;
namespace CleanCode
{
    public class ProductManager: IProductService
    {
            private IBankService bankService;

            public ProductManager(IBankService _bankService)
            {
                bankService = _bankService;
            }

            public void Sell(Product product, ICustomer customer)
            {
                decimal price = product.Price;
                price = customer.GetPrice(price);
                price = bankService.ConvertRate(new CurrencyRate() { Currency = 1, Price = price });
                Console.WriteLine(price);
                Console.ReadLine();
            }
        }
    }

