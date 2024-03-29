using RedisService.Services;

namespace RedisService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddGrpc();
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.MapGrpcService<GreeterService>();
            app.MapGrpcService<CustomerService>();
            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();
        }
    }
}