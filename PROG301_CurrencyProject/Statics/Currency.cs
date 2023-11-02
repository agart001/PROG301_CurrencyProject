using PROG301_CurrencyProject.Models;
using PROG301_CurrencyProject.Models.USCoins;

namespace PROG301_CurrencyProject.Statics
{
    public static class Currency
    {
        public struct US
        {
            public enum USCoinMintMark
            {
                P,
                D,
                S,
                W
            }

            public static Dictionary<USCoin, double> USCoinValueDict = new Dictionary<USCoin, double>
            {
                {new Penny(), .01},
                {new Nickel(), .05},
                {new Dime(), .10},
                {new Quarter(), .25},
                {new HalfDollar(), .50},
                {new DollarCoin(), 1.00}
            };
        }



    }
}