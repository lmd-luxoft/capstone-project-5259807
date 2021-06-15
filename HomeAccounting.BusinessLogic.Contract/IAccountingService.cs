using HomeAccounting.BusinessLogic.Contract.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract
{
    public interface IAccountingService
    {
        void CreateAccount(AccountModel accountModel);
    }
}
