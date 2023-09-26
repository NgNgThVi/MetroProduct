using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Application.Features.Users.Commands.UpdateUser;
using MetroDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Users.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        public DeleteUserCommandHandler(IUserRepository userRepository) => this._userRepository = userRepository;

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            // retrieve domain entity object
            var userDelete = await _userRepository.GetByIdAsync(request.Id);

            // verify that record exists
            if(userDelete == null) {
                throw new NotFoundExcrption(nameof(User.UserName), request.Id);
            }

            // rmove database
            await _userRepository.DeleteAsync(userDelete);

            // return
            return Unit.Value;
        }
    }
}
