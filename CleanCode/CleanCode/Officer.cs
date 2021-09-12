using System;
namespace CleanCode
{
    public class Officer : BaseEntity, ICustomer
    {
        public decimal GetPrice(decimal price)
        {
            return price * (decimal)0.80;
        }
    }
}
