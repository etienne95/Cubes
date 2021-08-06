using Cubes.Application.Services;
using Cubes.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Cubes.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IVolumeIntersectionCalculator, VolumeIntersectionCalculator>();
            return services;
        }
    }
}