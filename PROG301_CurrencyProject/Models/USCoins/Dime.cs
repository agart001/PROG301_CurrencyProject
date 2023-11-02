using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PROG301_CurrencyProject.Statics.Currency.US;

namespace PROG301_CurrencyProject.Models.USCoins
{
    public class Dime : USCoin
    {
        public Dime()
        {
            Value = USCoinValueDict[this];
        }
    }
}
