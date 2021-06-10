using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract.Entity
{
    public class Transaction
    {
        public OperationType OperationType { get; set; }

        public decimal Amount { get; set; }

        public Currency Currency { get; set; }

        public Asset PayerAsset { get; set; }

        public string PayerDescription { get; set; }

        public Asset ReceiverAsset { get; set; }

        public string ReceiverDescription { get; set; }


    }
}
