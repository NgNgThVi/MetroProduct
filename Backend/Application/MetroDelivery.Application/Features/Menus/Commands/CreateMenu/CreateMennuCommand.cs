using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Menus.Commands.CreateMenu
{
    public class CreateMennuCommand : IRequest<Guid>
    {

    }

    public class CreateMennuCommandHandle : IRequestHandler<CreateMennuCommand, Guid>
    {
        public Task<Guid> Handle(CreateMennuCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class CreateMennuCommandValidator : AbstractValidator<CreateMennuCommand>
    {

    }
}
