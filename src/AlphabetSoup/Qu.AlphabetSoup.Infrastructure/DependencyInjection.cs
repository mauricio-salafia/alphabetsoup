using Microsoft.Extensions.DependencyInjection;
using Qu.AlphabetSoup.Application.Interfaces;
using Qu.AlphabetSoup.Infrastructure.Implementations;

namespace Qu.AlphabetSoup.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IMatrixService, MatrixService>();
            return services;
        }
    }
}
