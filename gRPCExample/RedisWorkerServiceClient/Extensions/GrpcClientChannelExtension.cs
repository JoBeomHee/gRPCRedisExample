using Grpc.Net.Client;

namespace RedisWorkerServiceClient.Extensions;

public static class GrpcClientChannelExtension
{
    public static IServiceCollection AddGrpcClientChannel(this  IServiceCollection services)
    {
        var loggerFactory = LoggerFactory.Create(logging =>
        {
            logging.SetMinimumLevel(LogLevel.Debug);
        });
        var channel = GrpcChannel.ForAddress("https://localhost:7276");
        services.AddSingleton(channel);
        return services;
    }
}
