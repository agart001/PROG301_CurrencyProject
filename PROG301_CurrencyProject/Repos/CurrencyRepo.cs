using PROG301_CurrencyProject.Interfaces;
using PROG301_CurrencyProject.Models;
using static PROG301_CurrencyProject.Statics.Repos.CurRep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PROG301_CurrencyProject.Repos
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get; set; }

        public CurrencyRepo()
        {
            Coins = new List<ICoin>();
        }

        public string About()
        {
            throw new NotImplementedException();
        }

        #region Add/Remove Coin

        public void AddCoin(ICoin coin) => Coins.Add(coin);

        public void RemoveCoin(ICoin coin) => Coins.Remove(coin);

        #endregion

        #region Total/Count

        public int GetCoinCount() => Coins.Count();

        public double TotalValue() => Coins.OfType<Coin>().Sum(coin => coin.Value);

        #endregion

        #region Make Change
        public ICurrencyRepo MakeChange(double Amount)
        {
            ICurrencyRepo repo = Activator.CreateInstance(this.GetType()) as ICurrencyRepo;
            List<Coin> coins = CoinValsByType(this.GetType()).Cast<Coin>().ToList();

            coins.Sort((coin1, coin2) => -coin1.Value.CompareTo(coin2.Value));

            int amountInCents = (int)(Amount * 100);

            foreach (var coin in coins)
            {
                int coinValueInCents = (int)(coin.Value * 100);

                while (amountInCents >= coinValueInCents)
                {
                    if(amountInCents <= 0)
                    {
                        break;
                    }
                    repo.Coins.Add(coin);
                    amountInCents -= coinValueInCents;
                }
            }

            return repo;
        }

        public ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {
            double changeAmount = AmountTendered - TotalCost;

            ICurrencyRepo repo = Activator.CreateInstance(this.GetType()) as ICurrencyRepo;
            List<Coin> coins = CoinValsByType(this.GetType()).Cast<Coin>().ToList();

            coins.Sort((coin1, coin2) => -coin1.Value.CompareTo(coin2.Value));

            int amountInCents = (int)(changeAmount * 100);

            foreach (var coin in coins)
            {
                int coinValueInCents = (int)(coin.Value * 100);

                while (amountInCents >= coinValueInCents)
                {
                    if(amountInCents <= 0)
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
        public virtual ICurrencyRepo CreateChange(double Amount) => MakeChange(Amount);

        public virtual ICurrencyRepo CreateChange(double AmountTendered, double TotalCost) => MakeChange(AmountTendered, TotalCost);
        #endregion
    }
}
