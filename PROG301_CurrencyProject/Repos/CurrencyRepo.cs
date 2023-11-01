using PROG301_CurrencyProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG301_CurrencyProject.Repos
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string About()
        {
            throw new NotImplementedException();
        }

        public void AddCoin(ICoin coin)
        {
            throw new NotImplementedException();
        }

        public int GetCoinCount()
        {
            throw new NotImplementedException();
        }

        public ICurrencyRepo MakeChange(double Amount)
        {
            throw new NotImplementedException();
        }

        public ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {
            throw new NotImplementedException();
        }

        public void RemoveCoin(ICoin coin)
        {
            throw new NotImplementedException();
        }

        public double TotalValue()
        {
            throw new NotImplementedException();
        }
    }
}
