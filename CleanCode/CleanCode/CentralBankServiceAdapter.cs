using System;
namespace CleanCode
{
    public class CentralBankServiceAdapter : IBankService
    {
        //Adapter Design Patter
        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            CentralBankService centralBankService = new CentralBankService();
            return centralBankService.ConvertCurrency(currencyRate);
        }
    }
}
