using MediatR;
using CustomerDto = RedisService.Customer;

namespace RedisService.Commands;

public record AddCustomerCommand : IRequest<CustomerDto>
{
    public AddCustomerCommand(CustomerDto request)
    {
        Request = request;
    }

    public CustomerDto Request { get; }
}