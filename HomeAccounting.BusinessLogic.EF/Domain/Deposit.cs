

namespace HomeAccounting.BusinessLogic.EF.Domain
{
    public class Deposit : Account
    {
        public string NumberOfBankAccount { get; set; }

        public decimal Percent { get; set; }

        public string Name { get; set; }

        public PercentType Type { get; set; }

        public Bank Bank { get; set; }
    }
}