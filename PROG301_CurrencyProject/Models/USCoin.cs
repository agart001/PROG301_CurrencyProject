using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG301_CurrencyProject.Models
{
    public abstract class USCoin : Coin
    {
        public enum USCoinMintMark
        {
            P,
            D,
            S,
            W
        }

        public USCoinMintMark MintMark { get; set; }

        public string GetMintNameFromMark()
        {
            throw new NotImplementedException();
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
