using PROG301_CurrencyProject.Interfaces;
using PROG301_CurrencyProject.Repos;
using static PROG301_CurrencyProject.Statics.Currency.US;
using static PROG301_CurrencyProject.Utility.Method_Utils;

namespace PROG301_CurrencyProject.Statics
{
    /// <summary>
    /// This class represents a utility for managing different repositories of currency-related data.
    /// </summary>
    public static class Repos
    {
        /// <summary>
        /// This struct contains information and methods related to currency repositories.
        /// </summary>
        public struct CurRep
        {
            /// <summary>
            /// An array that holds types of currency repositories.
            /// </summary>
            public static Type[] Types = new Type[]
            {
                typeof(USCurrencyRepo)
            };

            /// <summary>
            /// Returns a list of coin values by the specified caller's type.
            /// </summary>
            /// <param name="caller">The Type of the caller requesting coin values.</param>
            /// <returns>A list of ICoin objects with values based on the caller's type.</returns>
            public static List<ICoin> CoinValsByType(Type caller)
            {
                List<ICoin> coins = new List<ICoin>();

                // Check if the caller's type is one of the supported currency repository types.
                if (Types.Contains(caller))
                {
                    if (caller == typeof(USCurrencyRepo))
                    {
                        // Handle US currency repository and populate the list with coin objects.
                        HandleUSCurrencyRepo(coins);
                    }
                }

                return coins;
            }

            /// <summary>
            /// Private method to handle US currency repository and create coin objects.
            /// </summary>
            /// <param name="coins">The list to populate with ICoin objects.</param>
            private static void HandleUSCurrencyRepo(List<ICoin> coins)
            {
                // Loop through USCoinValueDict and create ICoin objects for each coin type.
                foreach (var kvp in USCoinValueDict)
                {
                    ICoin coin = CreateInstance<ICoin>(kvp.Key);
                    coins.Add(coin);
                }
            }
        }
    }
}
