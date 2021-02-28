using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Provivi.MathOperations.Application;
using Provivi.MathOperations.DataAccess;
using Provivi.MathOperations.Domain;
using Provivi.MathOperations.IApplication;
using Provivi.MathOperations.IDataAccess;
using Provivi.MathOperations.IDomain;
using Provivi.MathOperations.IInfrastructure;
using Provivi.MathOperations.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Provivi.MathOperations.Service.Modules.Injection
{
    public static class InjectionExtensions
    {

        public static IServiceCollection AddInjection(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddSingleton<IConfiguration>(configuration);
            services.AddSingleton<IConnectionFactory, ConnectionFactory>();
            services.AddScoped<IMathOperationsRepository, MathOperationsRepository>();
            services.AddScoped<IMathOperationsDomain, MathOperationsDomain>();
           
            services.AddScoped<IMathOperationsApplication, MathOperationsApplication>();



            return services;
        }
    }
}
