using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NDDTraining.Domain.Interfaces.Repositories;
using NDDTraining.Infra.Data.Repository;

namespace NDDTraining.DI.IOC
{
    public static class RepositoryIoc
    {
        public static IServiceCollection RegisterServices(this IServiceCollection builder)
        {
           return builder
                .AddScoped<IModuleRepository, ModuleRepository>();

            
        }
    }
}
