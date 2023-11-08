using PROG301_CurrencyProject.Interfaces;
using PROG301_CurrencyProject.Models;
using static PROG301_CurrencyProject.Statics.Repos.CurRep;
using static PROG301_CurrencyProject.Utility.Method_Utils;

namespace PROG301_CurrencyProject.Repos
{
    /// <summary>
    /// This class represents a repository for managing various coins and currency operations.
    /// </summary>
    public class CurrencyRepo : ICurrencyRepo
    {
        /// <summary>
        /// Gets or sets a list that holds ICoin objects.
        /// </summary>
        public List<ICoin> Coins { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyRepo"/> class.
        /// </summary>
        public CurrencyRepo()
        {
            Coins = new List<ICoin>();
        }

        /// <summary>
        /// Placeholder method for describing the repository (to be implemented).
        /// </summary>
        public string About()
        {
            throw new NotImplementedException();
        }

        #region Add/Remove Coin

        /// <summary>
        /// Adds a coin to the repository.
        /// </summary>
        /// <param name="coin">The ICoin object to add to the repository.</param>
        public void AddCoin(ICoin coin) => Coins.Add(coin);

        /// <summary>
        /// Removes a coin from the repository.
        /// </summary>
        /// <param name="coin">The ICoin object to remove from the repository.</param>
        public void RemoveCoin(ICoin coin) => Coins.Remove(coin);

        #endregion

        #region Total/Count

        /// <summary>
        /// Returns the count of coins in the repository.
        /// </summary>
        /// <returns>The count of coins in the repository.</returns>
        public int GetCoinCount() => Coins.Count();

        /// <summary>
        /// Calculates and returns the total value of the coins in the repository.
        /// </summary>
        /// <returns>The total value of the coins in the repository.</returns>
        public double TotalValue() => Coins.OfType<Coin>().Sum(coin => coin.Value);

        #endregion

        #region Make Change

        /// <summary>
        /// Creates a new currency repository with change for a specified amount.
        /// </summary>
        /// <param name="Amount">The amount for which change needs to be made.</param>
        /// <returns>A new currency repository with the change for the specified amount.</returns>
        public ICurrencyRepo MakeChange(double Amount)
        {
            ICurrencyRepo repo = CreateInstance<ICurrencyRepo>(GetType());
            List<Coin> coins = CoinValsByType(this.GetType()).Cast<Coin>().ToList();

            // Sort the coins in descending order by value.
            coins.Sort((coin1, coin2) => -coin1.Value.CompareTo(coin2.Value));

            int amountInCents = (int)(Amount * 100);

            foreach (var coin in coins)
            {
                int coinValueInCents = (int)(coin.Value * 100);

                while (amountInCents >= coinValueInCents)
                {
                    if (amountInCents <= 0)
                    {
                        break;
                    }
                    repo.Coins.Add(coin);
                    amountInCents -= coinValueInCents;
                }
            }

            return repo;
        }

        /// <summary>
        /// Creates a new currency repository with change for a given amount tendered and total cost.
        /// </summary>
        /// <param name="AmountTendered">The amount tendered by the customer.</param>
        /// <param name="TotalCost">The total cost of the purchase.</param>
        /// <returns>A new currency repository with the change for the given transaction.</returns>
        public ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {
            double changeAmount = AmountTendered - TotalCost;

            
            ICurrencyRepo repo = CreateInstance<ICurrencyRepo>(GetType());
            List<Coin> coins = CoinValsByType(this.GetType()).Cast<Coin>().ToList();

            // Sort the coins in descending order by value.
            coins.Sort((coin1, coin2) => -coin1.Value.CompareTo(coin2.Value));

            int amountInCents = (int)(changeAmount * 100);

            foreach (var coin in coins)
            {
                int coinValueInCents = (int)(coin.Value * 100);

                while (amountInCents >= coinValueInCents)
                {
                    if (amountInCents <= 0)
                    {
                        break;
                    }
                    repo.Coins.Add(coin);
                    amountInCents -= coinValueInCents;
                }
            }

            return repo;
        }

        #endregion

        #region Create Change

        /// <summary>
        /// Creates change for a specified amount using the MakeChange method.
        /// </summary>
        /// <param name="Amount">The amount for which change needs to be made.</param>
        /// <returns>A new currency repository with the change for the specified amount.</returns>
        public virtual ICurrencyRepo CreateChange(double Amount) => MakeChange(Amount);

        /// <summary>
        /// Creates change for a given amount tendered and total cost using the MakeChange method.
        /// </summary>
        /// <param name="AmountTendered">The amount tendered by the customer.</param>
        /// <param name="TotalCost">The total cost of the purchase.</param>
        /// <returns>A new currency repository with the change for the given transaction.</returns>
        public virtual ICurrencyRepo CreateChange(double AmountTendered, double TotalCost) => MakeChange(AmountTendered, TotalCost);

        #endregion
    }
}
