using RedisWorkerServiceClient.Interfaces;

namespace RedisWorkerServiceClient
{
    public class CustomerService : BackgroundService
    {
        private readonly ILogger<CustomerService> _logger;
        private readonly IApiCustomerService _apiCustomerService;

        public CustomerService(ILogger<CustomerService> logger, IApiCustomerService apiCustomerService)
        {
            _logger = logger;
            _apiCustomerService = apiCustomerService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await _apiCustomerService.CreateCustomerInfoAsync("1");
            _logger.LogInformation($"Message Send Complete!!!!");
        }
    }
}
