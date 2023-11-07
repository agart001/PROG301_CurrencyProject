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
        }

        /// <summary>
        /// Provides information about the US coin.
        /// </summary>
        /// <returns>A string describing the US coin, including its name, year, value, and mint mark.</returns>
        public override string About() =>
            $"US {Name} is from {Year}. " +
            $"It is worth {Value:C}. " +
            $"It was made in {GetMintNameFromMark(MintMark)}";

        /// <summary>
        /// Gets the human-readable name of a US mint mark.
        /// </summary>
        /// <param name="mark">The USCoinMintMark to translate into a name.</param>
        /// <returns>A string representing the name of the mint mark.</returns>
        public static string GetMintNameFromMark(USCoinMintMark mark) => USCoinMintMarkDict[mark];
    }
}
