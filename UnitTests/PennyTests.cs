using PROG301_CurrencyProject.Models.USCoins;
using static PROG301_CurrencyProject.Statics.Currency.US;

namespace UnitTests
{
    /// <summary>
    /// Unit tests for the <see cref="Penny"/> class.
    /// </summary>
    [TestClass]
    public class PennyTests
    {
        /// <summary>
        /// Test the constructor of the <see cref="Penny"/> class.
        /// </summary>
        [TestMethod]
        public void PennyConstructor()
        {
            // Arrange
            Penny p, philiPenny;

            // Act 
            p = new Penny();
            philiPenny = new Penny(USCoinMintMark.P);

            // Assert
            // D is the default mint mark
            Assert.AreEqual(USCoinMintMark.D, p.MintMark);
            // Current Year is the default year
            Assert.AreEqual(DateTime.Now.Year, p.Year);

            Assert.AreEqual(USCoinMintMark.P, philiPenny.MintMark);
        }

        /// <summary>
        /// Test the monetary value of the <see cref="Penny"/> class.
        /// </summary>
        [TestMethod]
        public void PennyMonetaryValue()
        {
            // Arrange
            Penny p;

            // Act 
            p = new Penny();

            // Assert
            Assert.AreEqual(.01, p.Value);
        }

        /// <summary>
        /// Test the About method of the <see cref="Penny"/> class.
        /// </summary>
        [TestMethod]
        public void PennyAbout()
        {
            // Arrange
            Penny p;
            string pennyAbout;

            // Act 
            p = new Penny(USCoinMintMark.D);
            pennyAbout = p.About();

            // Assert
            Assert.AreEqual("US Penny is from 2017. It is worth $0.01. It was made in Denver", pennyAbout);
            // About output "US Penny is from 2017. It is worth $0.01. It was made in Denver"
        }
    }
}
