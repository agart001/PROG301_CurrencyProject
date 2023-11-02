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
            ICurrencyRepo repo = new CurrencyRepo();
            List<ICoin> coins = CoinValsByType(this.GetType());

            foreach (var coin in coins)
            {
                Coin actual = (Coin)coin;
                while (Amount >= actual.Value)
                {
                    repo.Coins.Add(coin);
                    Amount -= actual.Value;
                }
            }

            return repo;
        }

        public ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {
            if (AmountTendered < TotalCost)
            {
                Console.WriteLine("Error: Amount tendered is less than the total cost.");
                return null; // You may want to handle this error case differently
            }

            double changeAmount = AmountTendered - TotalCost;

            ICurrencyRepo repo = new CurrencyRepo();
            List<ICoin> coins = CoinValsByType(this.GetType());

            foreach (var coin in coins)
            {
                Coin actual = (Coin)coin;
                while (changeAmount >= actual.Value)
                {
                    repo.Coins.Add(coin);
                    changeAmount -= actual.Value;
                }
            }

            return repo;
        }
        #endregion

        #region Create Change
        public ICurrencyRepo CreateChange(double Amount) => MakeChange(Amount);

        public ICurrencyRepo CreateChange(double AmountTendered, double TotalCost) => MakeChange(AmountTendered, TotalCost);
        #endregion
    }
}
