using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.BusinessLogic.EF.AppLogic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.CompositionRoot
{
    public class AspNetApplicationBuilder : AbstractApplicationBuilder
    {
        public AspNetApplicationBuilder(IServiceCollection serviceCollection) : base(serviceCollection)
        {

        }

        protected override void RegisterBusinessLogic()
        {
            _serviceCollection.AddTransient<IAccountingService,AccountingService>();
        }

        protected override void RegisterDataSource()
        {
            _serviceCollection.AddDbContext<DomainContext>();
        }

        protected override void RegisterInfrastructure()
        {

        }
    }
}
