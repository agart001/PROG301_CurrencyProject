using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG301_CurrencyProject.Statics;
using static PROG301_CurrencyProject.Statics.Currency.US;

namespace PROG301_CurrencyProject.Models
{
    public abstract class USCoin : Coin
    {
        public USCoinMintMark MintMark { get; set; }
        public static string GetMintNameFromMark(USCoinMintMark mark)
        {
            string name;
            switch (mark)
            {
                case USCoinMintMark.P: name = "Philadephia"; break;
                case USCoinMintMark.D: name = "Denver"; break;
                case USCoinMintMark.S: name = "San Francisco"; break;
                case USCoinMintMark.W: name = "West Point"; break;
                default: name = "not found"; break;
            }
            return name;
        }

        public USCoin()
        {

        }

        public USCoin(USCoinMintMark mintMark)
        {
            MintMark = mintMark;
        }
    }
}
