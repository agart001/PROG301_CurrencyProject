using PROG301_CurrencyProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG301_CurrencyProject.Models
{
    public class Coin : ICurrency, ICoin
    {
        public double Value { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public Coin()
        {

        }

        public Coin(double value, string name, int year)
        {
            Value = value;
            Name = name;
            Year = year;
        }

        public string About()
        {
            throw new NotImplementedException();
        }
    }
}
