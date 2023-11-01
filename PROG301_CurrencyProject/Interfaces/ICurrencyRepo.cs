using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG301_CurrencyProject.Interfaces
{
    public interface ICurrencyRepo
    {
        public List<ICoin> Coins { get; set; }

        public string About();


        public void AddCoin(ICoin coin);

        public void RemoveCoin(ICoin coin);


        public int GetCoinCount();

        public double TotalValue();


        public ICurrencyRepo MakeChange(double Amount);

        public ICurrencyRepo MakeChange(double AmountTendered, double TotalCost);
    }
}
