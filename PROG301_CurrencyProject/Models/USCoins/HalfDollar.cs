using static PROG301_CurrencyProject.Statics.Currency.US;

namespace PROG301_CurrencyProject.Models.USCoins
{
    public class HalfDollar : USCoin
    {
        public HalfDollar() 
        {
            Value = USCoinValueDict[this];
        }
    }
}