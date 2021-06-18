using System;


namespace HomeAccounting.BusinessLogic.EF.Domain
{
    public class PropertyChange : Entity
    {
        public DateTime RegistrationDate { get; set; }

        public decimal Delta { get; set; }
    }
}