using Microsoft.Extensions.DependencyInjection;
using NDDTraining.Domain.Interfaces.Services;
using NDDTraining.Domain.Services;

namespace NDDTraining.DI.IOC
{
    public static class DI
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IModuleService, ModuleService>();
        }
    }
}
