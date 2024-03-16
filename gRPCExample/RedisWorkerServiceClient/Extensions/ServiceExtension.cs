using RedisWorkerServiceClient.Interfaces;

namespace RedisWorkerServiceClient.Extensions;

public static class ServiceExtension
{
    public static IServiceCollection AddApiClientService(this IServiceCollection services)
    {
        services.AddTransient<IApiCustomerService, ApiCustomerService>();
        return services;
    }
}
