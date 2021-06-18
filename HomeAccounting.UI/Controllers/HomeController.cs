using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.BusinessLogic.Contract.dto;
using HomeAccounting.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAccounting.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAccountingService _accountingService;

        public HomeController(
            ILogger<HomeController> logger,
            IAccountingService accountingService)
        {
            _logger = logger;
            _accountingService = accountingService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CreateAccounts()
        {
            _accountingService.CreateAccount(new AccountModel
            {
                Title = "Simple Account 1",
                Amount = 50000,
                Type = AccountType.Simple
            });

            _accountingService.CreateAccount(new AccountModel
            {
                Title = "Simple Account 2",
                Amount = 10000,
                Type = AccountType.Simple
            });

            _accountingService.CreateAccount(new CashModel
            {
                Title = "Cash 1",
                Amount = 2000,
                Type = AccountType.Cash,
                Banknotes = 1,
                Monets = 0
            });

            _accountingService.CreateAccount(new CashModel
            {
                Title = "Cash 2",
                Amount = 210,
                Type = AccountType.Cash,
                Banknotes = 2,
                Monets = 10
            });

            _accountingService.CreateAccount(new PropertyModel
            {
                Title = "Property 1",
                Amount = 2000000,
                Type = AccountType.Property,
                BasePrice = 2000000,
                Location = "mo"
            });

            _accountingService.CreateAccount(new DepositModel
            {
                Title = "Deposit 1",
                Amount = 1500000,
                Type = AccountType.Deposit,
                NumberOfBankAccount = "12345678909876543210",
                Percent = 5,
                Name = "saving",
                BIC = "111000",
                CorrespondetAccount = "98765432101234567890",
                BankTitle = "Sber"
            });

            return Json(new { Status = true });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
