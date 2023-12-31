using PROG301_CurrencyProject.Models.USCoins;
using PROG301_CurrencyProject.Models.UKCoins;
using PROG301_CurrencyProject.Models;

namespace PROG301_CurrencyProject.Statics
{
    /// <summary>
    /// This class represents a static utility for managing currency-related data.
    /// </summary>
    public static class Currency
    {
        /// <summary>
        /// This region contains a set of dictionaries and functions, which map different depencies based on
        /// a currency's type.
        /// </summary>
        #region Currency Type References
        /// <summary>
        /// A dictionary that maps coin types to their respective regions.
        /// </summary>
        public static Dictionary<Type, string> CurRegionDict = new Dictionary<Type, string>()
        {
            {typeof(USCoin), "US"},
            {typeof(UKCoin), "UK"}
        };

        /// <summary>
        /// A dictionary that maps coin types to their respective symbols.
        /// </summary>
        public static Dictionary<Type, string> CurSymbolDict = new Dictionary<Type, string>()
        {
            {typeof(USCoin), "$"},
            {typeof(UKCoin), "£"}
        };

        /// <summary>
        /// A dictionary that maps coin types to their respective mint mark dictionaries.
        /// </summary>
        public static Dictionary<Type, Dictionary<Enum, string>> CurMintMarkDict = new Dictionary<Type, Dictionary<Enum, string>>()
        {
            {typeof(USCoin), GetMintMarkDict(US.USCoinMintMarkDict)},
            {typeof(UKCoin), GetMintMarkDict(UK.UKCoinMintMarkDict)}
        };

        /// <summary>
        /// Converts a dictionary with enum keys and string values to a dictionary with Enum keys and string values.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum keys in the input dictionary.</typeparam>
        /// <param name="mintMarkDict">The dictionary containing enum keys and string values representing mint marks.</param>
        /// <returns>A new dictionary with Enum keys and string values.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="mintMarkDict"/> is null.</exception>
        static Dictionary<Enum, string> GetMintMarkDict<TEnum>(Dictionary<TEnum, string> mintMarkDict)
            where TEnum : Enum
        {
            if (mintMarkDict is null) { throw new ArgumentNullException(nameof(mintMarkDict)); }

            var resultDict = new Dictionary<Enum, string>();

            foreach (var entry in mintMarkDict)
            {
                resultDict.Add(entry.Key, entry.Value);
            }

            return resultDict;
        }
        #endregion

        /// <summary>
        /// This region contains dependencies for US Currency.
        /// </summary>
        #region US Currency
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
        #endregion

        /// <summary>
        /// This region contains dependencies for UK Currency.
        /// </summary>
        #region UK Currency
        /// <summary>
        /// This struct contains information about UK coins.
        /// </summary>
        public struct UK
        {
            /// <summary>
            /// This enum defines different mint marks for UK coins.
            /// </summary>
            public enum UKCoinMintMark
            {
                /// <summary>
                /// The mint mark for coins produced by the Royal Mint.
                /// </summary>
                R,

                /// <summary>
                /// The mint mark for coins produced by the Birmingham Mint.
                /// </summary>
                B,

                /// <summary>
                /// The mint mark for coins produced by the Manchester Mint.
                /// </summary>
                M,

                /// <summary>
                /// The mint mark for coins produced by the Edinburgh Mint.
                /// </summary>
                E
            }

            /// <summary>
            /// A dictionary that maps UKCoinMintMark values to their respective human-readable names.
            /// </summary>
            public static Dictionary<UKCoinMintMark, string> UKCoinMintMarkDict = new Dictionary<UKCoinMintMark, string>
            {
                {UKCoinMintMark.R, "Royal Mint"},
                {UKCoinMintMark.B, "Birmingham Mint"},
                {UKCoinMintMark.M, "Manchester Mint"},
                {UKCoinMintMark.E, "Edinburgh Mint"}
            };

            /// <summary>
            /// A dictionary that maps coin types to their respective values in pounds.
            /// </summary>
            public static Dictionary<Type, double> UKCoinValueDict = new Dictionary<Type, double>
            {
                {typeof(Pence), 0.01},
                {typeof(TwoPence), 0.02},
                {typeof(FivePence), 0.05},
                {typeof(TenPence), 0.10},
                {typeof(TwentyPence), 0.20},
                {typeof(FiftyPence), 0.5},
                {typeof(Pound), 1.00},
                {typeof(TwoPound), 2.00}
            };

            /// <summary>
            /// A dictionary that maps coin types to their human-readable names.
            /// </summary>
            public static Dictionary<Type, string> UKCoinNameDict = new Dictionary<Type, string>
            {
                {typeof(Pence), "Pence"},
                {typeof(TwoPence), "Two Pence"},
                {typeof(FivePence), "Five Pence"},
                {typeof(TenPence), "Ten Pence"},
                {typeof(TwentyPence), "Twenty Pence"},
                {typeof(FiftyPence), "Fifty Pence"},
                {typeof(Pound), "Pound"},
                {typeof(TwoPound), "Two Pound"}
            };
        }
        #endregion
    }
}
