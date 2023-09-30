using MediatR;

namespace MetroDelivery.Application.Features.Users.Queries.GetUserDetail
{
    public class GetUserDetailQuery : IRequest<CustomerDto>
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
