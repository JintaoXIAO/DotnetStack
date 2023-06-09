using DependencyInjectionSample.Interfaces;
using DependencyInjectionSample.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionSample;

public static class MyDependencyServiceExtensions
{
    public static IServiceCollection AddMyDependency(this IServiceCollection services)
    {
        services.AddScoped<IMyDependency, MyDependency>();
        services.AddScoped<IMyDependency, MyDependency2>();
        return services;
    }
}