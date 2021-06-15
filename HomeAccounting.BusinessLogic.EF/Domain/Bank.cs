

namespace HomeAccounting.BusinessLogic.EF.Domain
{
    public class Bank : Entity
    {
        public string BIC { get; set; }

        public string CorrespondetAccount { get; set; }

        public string Title { get; set; }
    }
}