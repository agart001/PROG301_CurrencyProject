using static PROG301_CurrencyProject.Statics.Currency.US;

namespace PROG301_CurrencyProject.Models.USCoins
{
    public class DollarCoin : USCoin
    {
        public DollarCoin() 
        {
            Value = USCoinValueDict[this];
        }
    }
}
