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

            public static Dictionary<Type, double> USCoinValueDict = new Dictionary<Type, double>
            {
                {typeof(Penny), .01},
                {typeof(Nickel), .05},
                {typeof(Dime), .10},
                {typeof(Quarter), .25},
                {typeof(HalfDollar), .50},
                {typeof(DollarCoin), 1.00}
            };

            public static Dictionary<Type, string> USCoinNameDict = new Dictionary<Type, string>
            {
                {typeof(Penny), "Penny"},
                {typeof(Nickel), "Nickel"},
                {typeof(Dime), "Dime"},
                {typeof(Quarter), "Quarter"},
                {typeof(HalfDollar), "Half Dollar"},
                {typeof(DollarCoin), "Dollar Coin"}
            };
        }



    }
}