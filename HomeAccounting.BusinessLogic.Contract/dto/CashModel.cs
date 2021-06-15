using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract.dto
{
    public class CashModel : AccountModel
    {
        public int Banknotes { get; set; }

        public int Monets { get; set; }
    }
}
