using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract.Entity
{
    public class Asset
    {
        public long Id { get; set; }

        public AssetType AssetType { get; set; }

        public string Name { get; set; }

        public decimal Value { get; set; }

        public Currency Currency { get; set; }

        public string Description { get; set; }
    }
}
