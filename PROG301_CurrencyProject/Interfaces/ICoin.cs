
namespace PROG301_CurrencyProject.Interfaces
{
    /// <summary>
    /// Represents an interface for defining a coin with a year of issue.
    /// </summary>
    public interface ICoin
    {
        /// <summary>
        /// Gets or sets the year of issue of the coin.
        /// </summary>
        public int Year { get; set; }
    }
}
