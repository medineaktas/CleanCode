using System;
namespace CleanCode
{
    public interface IBankService
    {
        decimal ConvertRate(CurrencyRate currencyRate);
    }
}
