using MediatR;

namespace MetroDelivery.Application.Features.Customers.Queries.GetAllCustomers
{
    /*public class GetListUserQuery : IRequest<List<UserDto>>
    {

    }*/

    public record GetListCustomerQuery : IRequest<List<CustomerDto>>
    {

    }
}
