using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract.Entity
{
    public class ExchangeRate
    {
        public Currency CurrencyIn { get; set; }

        public Currency CurrencyOut { get; set; }

        public decimal Rate { get; set; }
    }
}
