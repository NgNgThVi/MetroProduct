using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Users.Queries.GetAllUsers
{
    /*public class GetListUserQuery : IRequest<List<UserDto>>
    {

    }*/

    public record GetListCustomerQuery : IRequest<List<CustomerDto>>
    {

    }
}
