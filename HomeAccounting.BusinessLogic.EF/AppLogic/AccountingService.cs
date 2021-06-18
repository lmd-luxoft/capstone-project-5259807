using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.BusinessLogic.Contract.dto;
using HomeAccounting.BusinessLogic.EF.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeAccounting.BusinessLogic.EF.AppLogic
{
    public class AccountingService : IAccountingService
    {
        DomainContext _domainContext;

        public AccountingService(DomainContext domainContext)
        {
            _domainContext = domainContext;
        }

        public void CreateAccount(AccountModel accountModel)
        {
            switch(accountModel.Type)
            {
                case AccountType.Simple:
                    CreateSimpleAccount(accountModel);
                    break;
                case AccountType.Cash:
                    CreateCashAccount((CashModel)accountModel);
                    break;
                case AccountType.Property:
                    CreatePropertyAccount((PropertyModel)accountModel);
                    break;
                case AccountType.Deposit:
                    CreateDepositAccount((DepositModel)accountModel);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void CreateSimpleAccount(AccountModel accountModel)
        {
            Account account = new Account
            {
                Balance = accountModel.Amount,
                CreationDate = DateTime.Now,
                Title = accountModel.Title
            };

            _domainContext.Accounts.Add(account);

            _domainContext.SaveChanges();    
        }

        private void CreateCashAccount(CashModel cashModel)
        {
            Cash cash = new Cash
            {
                Balance = cashModel.Amount,
                CreationDate = DateTime.Now,
                Title = cashModel.Title,
                Banknotes = cashModel.Banknotes,
                Monets = cashModel.Monets
            };

            _domainContext.Cashes.Add(cash);

            //_domainContext.SaveChanges();
        }

        private void CreatePropertyAccount(PropertyModel propertyModel)
        {
            Property property = new Property
            {
                Balance = propertyModel.Amount,
                CreationDate = DateTime.Now,
                Title = propertyModel.Title,
                BasePrice = propertyModel.BasePrice,
                Location = propertyModel.Location,
                Type = PropertyType.NoMoveable
            };

            _domainContext.Properties.Add(property);

            //_domainContext.SaveChanges();
        }

        private void CreateDepositAccount(DepositModel depositModel)
        {
            var bank = _domainContext.Banks.Where(x => x.BIC == depositModel.BIC).FirstOrDefault();

            if (bank == null)
            {
                bank = new Bank
                {
                    BIC = depositModel.BIC,
                    CorrespondetAccount = depositModel.CorrespondetAccount,
                    Title = depositModel.BankTitle
                };

                _domainContext.Banks.Add(bank);
            }

            Deposit deposit = new Deposit
            {
                Balance = depositModel.Amount,
                CreationDate = DateTime.Now,
                Title = depositModel.Title,
                NumberOfBankAccount = depositModel.NumberOfBankAccount,
                Percent = depositModel.Percent,
                Name = depositModel.Name,
                Type = PercentType.ByFixed,
                Bank = bank
            };

            _domainContext.Deposit.Add(deposit);

            //_domainContext.SaveChanges();
        }
    }
}
