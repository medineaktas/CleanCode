using System;
namespace CleanCode
{
    public interface IProductService
    {
        void Sell(Product product, ICustomer customer);
    }
}
