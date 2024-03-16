using RedisWorkerServiceClient.Extensions;

namespace RedisWorkerServiceClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHostedService<CustomerService>();
                    services.AddGrpcClientChannel();
                    services.AddApiClientService();
                })
                .Build();

            host.Run();
        }
    }
}