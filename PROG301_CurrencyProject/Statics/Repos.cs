using Microsoft.VisualBasic;
using PROG301_CurrencyProject.Interfaces;
using PROG301_CurrencyProject.Repos;
using static PROG301_CurrencyProject.Statics.Currency.US;

namespace PROG301_CurrencyProject.Statics
{
    public static class Repos
    {

        public struct CurRep
        {
            public static Type[] Types = new Type[]
            {
                typeof(USCurrencyRepo)
            };

            public static List<ICoin> CoinValsByType(Type caller)
            {
                List<ICoin> coins = new List<ICoin>();

                if(Types.Contains(caller))
                {
                    if(caller == typeof(USCurrencyRepo))
                    {
                        HandleUSCurrencyRepo(coins);
                    }


                }


                return coins;
            }

            private static void HandleUSCurrencyRepo(List<ICoin> coins)
            {
                foreach(var kvp in USCoinValueDict)
                {
                    coins.Add(kvp.Key);
                }
            }
        }

    }
}