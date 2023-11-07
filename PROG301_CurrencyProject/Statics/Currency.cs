using PROG301_CurrencyProject.Models.USCoins;

namespace PROG301_CurrencyProject.Statics
{
    /// <summary>
    /// This class represents a static utility for managing US currency-related data.
    /// </summary>
    public static class Currency
    {
        /// <summary>
        /// This struct contains information about US coins.
        /// </summary>
        public struct US
        {
            /// <summary>
            /// This enum defines different mint marks for US coins.
            /// </summary>
            public enum USCoinMintMark
            {
                P,  // Philadelphia Mint
                D,  // Denver Mint
                S,  // San Francisco Mint
                W   // West Point Mint
            }

            /// <summary>
            /// A dictionary mapping coin types to their respective values in dollars.
            /// </summary>
            public static Dictionary<Type, double> USCoinValueDict = new Dictionary<Type, double>
            {
                {typeof(Penny), .01},
                {typeof(Nickel), .05},
                {typeof(Dime), .10},
                {typeof(Quarter), .25},
                {typeof(HalfDollar), .50},
                {typeof(DollarCoin), 1.00}
            };

            /// <summary>
            /// A dictionary mapping coin types to their human-readable names.
            /// </summary>
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
