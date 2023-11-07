
namespace PROG301_CurrencyProject.Interfaces
{
    /// <summary>
    /// Represents an interface for defining currency with a value and a name.
    /// </summary>
    public interface ICurrency
    {
        /// <summary>
        /// Gets or sets the value of the currency.
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Gets or sets the name of the currency.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Provides information about the currency.
        /// </summary>
        /// <returns>A string describing the currency.</returns>
        public string About();
    }
}
