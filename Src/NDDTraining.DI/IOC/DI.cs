using Microsoft.Extensions.DependencyInjection;

namespace NDDTraining.DI.IOC
{
    public static class DI
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            return services;
        }
    }
}
