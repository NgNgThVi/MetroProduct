using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Users.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string NewUserName { get; set; }
        public string NewPassword { get; set; }
        public string NewEmail { get; set; }
        public string NewRole { get; set; }
        public string NewPhone { get; set; }
        public string NewAddress { get; set; }
    }
}
