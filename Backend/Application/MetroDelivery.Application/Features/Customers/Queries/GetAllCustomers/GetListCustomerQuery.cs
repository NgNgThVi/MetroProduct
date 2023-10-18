using MediatR;

namespace MetroDelivery.Application.Features.Customers.Queries.GetAllCustomers
{
    public record GetListCustomerQuery : IRequest<List<CustomerResponse>>
    {
    }
}
