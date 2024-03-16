using MediatR;
using RedisService.Commands;
using RedisService.Services;
using CustomerDto = RedisService.Customer;

namespace RedisService.Handlers;

public class AddCustomerHandler : IRequestHandler<AddCustomerCommand, CustomerDto>
{
    private readonly RedisManagerService _redisManagerService;
    public AddCustomerHandler()
    {
        _redisManagerService = new RedisManagerService();
    }

    public async Task<CustomerDto> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
    {
        await _redisManagerService.Push(request.Request.Name);

        return new CustomerDto
        {
            Id = request.Request.Id,
            Name = request.Request.Name,
            Email = request.Request.Email,
            Password = request.Request.Password
        }; ;
    }
}
