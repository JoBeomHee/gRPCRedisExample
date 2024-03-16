using Grpc.Core;
using Grpc.Net.Client;
using RedisService;
using RedisWorkerServiceClient.Interfaces;

namespace RedisWorkerServiceClient;

public class ApiCustomerService : IApiCustomerService
{
    private readonly GrpcChannel _channel;

    public ApiCustomerService(GrpcChannel channel)
    {
        _channel = channel;
    }

    public async Task CreateCustomerInfoAsync(string customerId)
    {
        try
        {
            var client = new CustomersGrpc.CustomersGrpcClient(_channel);
            var newCustomer = new Customer
            {
                Email = "afsdzvcx123@naver.com",
                Id = 1,
                Name = "beombeomjojo",
                Password = "1234"
            };
            var clientRequested = new CreateCustomerRequest { Customer = newCustomer };
            var customer = await client.CreateCustomerAsync(clientRequested);
        }
        catch (RpcException)
        {
            throw;
        }
    }
}
