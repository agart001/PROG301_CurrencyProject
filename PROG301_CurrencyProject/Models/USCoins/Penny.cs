using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG301_CurrencyProject.Statics;
using static PROG301_CurrencyProject.Statics.Currency.US;

namespace PROG301_CurrencyProject.Models.USCoins
{
    public class Penny : USCoin
    {
        public Penny()
        {
            Value = USCoinValueDict[this];
        }
    }
}
