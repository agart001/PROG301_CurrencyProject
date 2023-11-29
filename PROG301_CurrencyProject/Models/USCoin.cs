using static PROG301_CurrencyProject.Statics.Currency;
using static PROG301_CurrencyProject.Statics.Currency.US;

namespace PROG301_CurrencyProject.Models
{
    /// <summary>
    /// Represents an abstract class for US coins with properties such as MintMark, Year, Name, and Value.
    /// </summary>
    public abstract class USCoin : Coin
    {
        /// <summary>
        /// Gets or sets the mint mark of the US coin.
        /// </summary>
        public USCoinMintMark MintMark { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="USCoin"/> class with default values.
        /// </summary>
        public USCoin()
        {
            MintMark = USCoinMintMark.D;
            Year = DateTime.Now.Year;
            Name = USCoinNameDict[GetType()];
            Value = USCoinValueDict[GetType()];

            SetDesc
            (
                CurRegionDict[typeof(USCoin)], 
                CurSymbolDict[typeof(USCoin)], 
                USCoinMintMarkDict[MintMark]
            );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="USCoin"/> class with the specified mint mark.
        /// </summary>
        /// <param name="mintMark">The mint mark of the US coin.</param>
        public USCoin(USCoinMintMark mintMark)
        {
            MintMark = mintMark;
            Year = DateTime.Now.Year;
            Name = USCoinNameDict[GetType()];
            Value = USCoinValueDict[GetType()];

            SetDesc
            (
                CurRegionDict[typeof(USCoin)], 
                CurSymbolDict[typeof(USCoin)], 
                USCoinMintMarkDict[MintMark]
            );
        }
    }
}
