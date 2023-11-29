using static PROG301_CurrencyProject.Statics.Currency.UK;

namespace PROG301_CurrencyProject.Models.UKCoins
{
    public class TwoPound : UKCoin
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwoPound"/> class.
        /// </summary>
        public TwoPound() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoPound"/> class with the specified mint mark.
        /// </summary>
        /// <param name="mark">The mint mark of the Two Pound.</param>
        public TwoPound(UKCoinMintMark mark) : base(mark)
        {
        }
    }
}