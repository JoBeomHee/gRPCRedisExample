namespace RedisWorkerServiceClient.Interfaces;

public interface IApiCustomerService
{
    Task CreateCustomerInfoAsync(string customerId); 
}
