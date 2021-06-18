using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract.dto
{
    public class DepositModel : AccountModel
    {
        public string NumberOfBankAccount { get; set; }

        public decimal Percent { get; set; }

        public string Name { get; set; }

        public string BIC { get; set; }

        public string CorrespondetAccount { get; set; }

        public string BankTitle { get; set; }
    }
}
