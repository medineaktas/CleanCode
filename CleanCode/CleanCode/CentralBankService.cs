using System;
namespace CleanCode
{
    public class CentralBankService 
    {
        public decimal ConvertCurrency(CurrencyRate currencyRate)
        {
            return currencyRate.Price / (decimal)5.28;
        }
    }
}
