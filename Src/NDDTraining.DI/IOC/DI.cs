using Microsoft.Extensions.DependencyInjection;
using NDDTraining.Domain.Interfaces.Services;

namespace NDDTraining.DI.IOC
{
    public static class DI
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            return services
                .AddScoped<IModuleService>();
        }
    }
}
