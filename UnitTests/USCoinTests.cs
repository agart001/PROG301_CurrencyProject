using PROG301_CurrencyProject.Models.USCoins;
using PROG301_CurrencyProject.Models;
using static PROG301_CurrencyProject.Statics.Currency.US;
using PROG301_CurrencyProject.Statics;

namespace UnitTests
{
    /// <summary>
    /// Unit tests for the <see cref="USCoin"/> class and its derived classes.
    /// </summary>
    [TestClass]
    public class USCoinTests
    {
        Penny p;

        /// <summary>
        /// Initializes an instance of the <see cref="USCoinTests"/> class.
        /// </summary>
        public USCoinTests()
        {
            p = new Penny();
        }

        /// <summary>
        /// Test the constructor of the <see cref="Penny"/> class.
        /// </summary>
        [TestMethod]
        public void USCoinPennyConstructor()
        {
            // Arrange
            p = new Penny();

            // Assert
            Assert.AreEqual(Currency.US.USCoinMintMark.D, p.MintMark); // D is the default mint mark
            Assert.AreEqual(DateTime.Now.Year, p.Year); // Current year is the default year
        }

        /// <summary>
        /// Test the GetMintNameFromMark method of the <see cref="USCoin"/> class.
        /// </summary>
        [TestMethod]
        public void USCoinMintMark()
        {
            // Arrange
            string mintNameDenver, mintNamePhili, mintNameSanFran, mintNameWestPoint;
            USCoinMintMark D, P, S, W;

            // Act 
            mintNameDenver = "Denver";
            mintNamePhili = "Philadelphia";
            mintNameSanFran = "San Francisco";
            mintNameWestPoint = "West Point";
            D = Currency.US.USCoinMintMark.D;
            P = Currency.US.USCoinMintMark.P;
            S = Currency.US.USCoinMintMark.S;
            W = Currency.US.USCoinMintMark.W;

            // Assert
            Assert.AreEqual(USCoin.GetMintNameFromMark(D), mintNameDenver);
            Assert.AreEqual(USCoin.GetMintNameFromMark(P), mintNamePhili);
            Assert.AreEqual(USCoin.GetMintNameFromMark(S), mintNameSanFran);
            Assert.AreEqual(USCoin.GetMintNameFromMark(W), mintNameWestPoint);
        }

        /// <summary>
        /// Test the monetary value of the <see cref="Penny"/> class.
        /// </summary>
        [TestMethod]
        public void USCoinPennyMonetaryValue()
        {
            // Arrange
            p = new Penny();

            // Assert
            Assert.AreEqual(.01, p.Value);
        }

        /// <summary>
        /// Test the About method of the <see cref="Penny"/> class.
        /// </summary>
        [TestMethod]
        public void USCoinPennyAbout()
        {
            // Arrange
            p = new Penny(Currency.US.USCoinMintMark.D);

            // Assert
            Assert.AreEqual("US Penny is from 2017. It is worth $0.01. It was made in Denver", p.About());
        }
    }
}
