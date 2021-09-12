using System;
namespace CleanCode
{
    public interface ICustomer
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal GetPrice(decimal price);
    }
}
