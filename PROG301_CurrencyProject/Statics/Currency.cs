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
                /// <summary>
                /// The mint mark for coins produced by the Philadelphia Mint.
                /// </summary>
                P,  // Philadelphia Mint

                /// <summary>
                /// The mint mark for coins produced by the Denver Mint.
                /// </summary>
                D,  // Denver Mint

                /// <summary>
                /// The mint mark for coins produced by the San Francisco Mint.
                /// </summary>
                S,  // San Francisco Mint

                /// <summary>
                /// The mint mark for coins produced by the West Point Mint.
                /// </summary>
                W   // West Point Mint
            }

            /// <summary>
            /// A dictionary that maps USCoinMintMark values to their respective human-readable names.
            /// </summary>
            public static Dictionary<USCoinMintMark, string> USCoinMintMarkDict = new Dictionary<USCoinMintMark, string>
            {
                {USCoinMintMark.P, "Philadelphia"},
                {USCoinMintMark.D, "Denver"},
                {USCoinMintMark.S, "San Francisco"},
                {USCoinMintMark.W, "West Point"}
            };

            /// <summary>
            /// A dictionary that maps coin types to their respective values in dollars.
            /// </summary>
            public static Dictionary<Type, double> USCoinValueDict = new Dictionary<Type, double>
            {
                {typeof(Penny), 0.01},
                {typeof(Nickel), 0.05},
                {typeof(Dime), 0.10},
                {typeof(Quarter), 0.25},
                {typeof(HalfDollar), 0.50},
                {typeof(DollarCoin), 1.00}
            };

            /// <summary>
            /// A dictionary that maps coin types to their human-readable names.
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
