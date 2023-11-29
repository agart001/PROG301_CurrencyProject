using PROG301_CurrencyProject.Models.UKCoins;
using static PROG301_CurrencyProject.Statics.Currency.UK;

namespace UnitTests
{
    /// <summary>
    /// Unit tests for the <see cref="Pence"/> class.
    /// </summary>
    [TestClass]
    public class PenceTests
    {
        /// <summary>
        /// Test the constructor of the <see cref="Pence"/> class.
        /// </summary>
        [TestMethod]
        public void PenceConstructor()
        {
            // Arrange
            Pence p, manPence;

            // Act 
            p = new Pence();
            manPence = new Pence(UKCoinMintMark.M);

            // Assert
            // D is the default mint mark
            Assert.AreEqual(UKCoinMintMark.R, p.MintMark);
            // Current Year is the default year
            Assert.AreEqual(DateTime.Now.Year, p.Year);

            Assert.AreEqual(UKCoinMintMark.M, manPence.MintMark);
        }

        /// <summary>
        /// Test the monetary value of the <see cref="Pence"/> class.
        /// </summary>
        [TestMethod]
        public void PenceMonetaryValue()
        {
            // Arrange
            Pence p;

            // Act 
            p = new Pence();

            // Assert
            Assert.AreEqual(.01, p.Value);
        }

        /// <summary>
        /// Test the About method of the <see cref="Pence"/> class.
        /// </summary>
        [TestMethod]
        public void PenceAbout()
        {
            // Arrange
            Pence p;
            string PenceAbout;

            // Act 
            p = new Pence(UKCoinMintMark.B);
            PenceAbout = p.About();

            // Assert
            Assert.AreEqual($"UK Pence is from {DateTime.Now.Year}. It is worth $0.01. It was made in Denver", PenceAbout);
            // About output "US Pence is from 2017. It is worth $0.01. It was made in Denver"
        }
    }
}
