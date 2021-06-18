

namespace HomeAccounting.BusinessLogic.EF.Domain
{
    public class Cash : Account
    {
        public int Banknotes { get; set; }

        public int Monets { get; set; }
    }
}