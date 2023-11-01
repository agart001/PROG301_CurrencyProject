using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG301_CurrencyProject.Interfaces
{
    public interface ICurrency
    {
        public double Value { get; set; }

        public string Name { get; set; }

        public string About();
    }
}
