using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Users.Queries.GetUserById
{
    public record GetUserByIdQuery(Guid id) : IRequest<CustomerDto>;
}
