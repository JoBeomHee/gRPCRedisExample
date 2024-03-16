using Grpc.Core;
using MediatR;
using RedisService.Commands;

namespace RedisService.Services;

public class CustomerService : CustomersGrpc.CustomersGrpcBase
{
    private readonly ILogger<CustomerService> _logger;
    private readonly IMediator _mediator;

    public CustomerService(ILogger<CustomerService> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    public override async Task<CreateCustomerReply> CreateCustomer(CreateCustomerRequest request, ServerCallContext context)
    => new CreateCustomerReply() { Customer = await _mediator.Send(new AddCustomerCommand(request.Customer)) };    
}
