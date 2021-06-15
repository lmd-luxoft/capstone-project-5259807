using System.Collections.Generic;


namespace HomeAccounting.BusinessLogic.EF.Domain
{
    public class Operation : Entity
    {
        public System.DateTime ExecutionDate { get; set; }

        public decimal Amount { get; set; }

        public IEnumerable<Account> Account { get; set; }
    }
}