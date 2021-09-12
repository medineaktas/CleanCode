using System;
namespace CleanCode
{
    public class Student : BaseEntity , ICustomer
    {
        public decimal GetPrice(decimal price)
        {
            return price * (decimal)0.90;
        }
    }
}
