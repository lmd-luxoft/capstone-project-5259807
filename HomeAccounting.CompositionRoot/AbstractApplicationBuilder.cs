using HomeAccounting.BusinessLogic.EF.AppLogic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.CompositionRoot
{
    public abstract class AbstractApplicationBuilder
    {
        protected readonly IServiceCollection _serviceCollection;

        protected abstract void RegisterBusinessLogic();

        protected abstract void RegisterDataSource();

        protected abstract void RegisterInfrastructure();

        public AbstractApplicationBuilder(IServiceCollection serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        public void Build()
        {
            RegisterInfrastructure();
            RegisterDataSource();
            RegisterBusinessLogic();
        }
    }
}
