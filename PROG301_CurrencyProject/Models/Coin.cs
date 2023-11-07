using PROG301_CurrencyProject.Interfaces;

namespace PROG301_CurrencyProject.Models
{
    /// <summary>
    /// Represents a coin with a value, a name, and a year of issue.
    /// </summary>
    public class Coin : ICurrency, ICoin
    {
        /// <summary>
        /// Gets or sets the value of the coin.
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Gets or sets the name of the coin.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the year of issue of the coin.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coin"/> class.
        /// </summary>
        public Coin()
        {
            // Default constructor for the coin.
        }

        /// <summary>
        /// Provides information about the coin (to be implemented).
        /// </summary>
        /// <returns>A string describing the coin.</returns>
        public virtual string About()
        {
            throw new NotImplementedException();
        }
    }
}
