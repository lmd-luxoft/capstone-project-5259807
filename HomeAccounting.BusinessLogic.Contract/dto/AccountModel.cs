using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract.dto
{
    public enum AccountType
    {
        Simple,
        Deposit,
        Property,
        Cash
    }

    public class AccountModel
    {
        public string Title { get; set; }

        public decimal Amount { get; set; }

        public AccountType Type { get; set; }
    }
}
