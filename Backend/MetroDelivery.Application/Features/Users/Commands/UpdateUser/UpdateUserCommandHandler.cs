using AutoMapper;
using MediatR;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UpdateUserCommandHandler(IMapper mapper, IUserRepository userRepository)
        {
            this._mapper = mapper;
            this._userRepository = userRepository;
        }

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            // validate incoming data
            var user = await _userRepository.GetByIdAsync(request.Id);

            if (user == null) {
                throw new Exception("User not found");
            }
            user.UserName = request.NewUserName;
            user.Password = request.NewPassword;
            user.Email = request.NewEmail;
            user.Role = request.NewRole;
            user.Address = request.NewAddress;
            // convert to domain entity object
            var userUpdate = _mapper.Map<User>(user);

            // add database
            await _userRepository.UpdateAsync(userUpdate);


            // return
            return Unit.Value;
        }
    }
}
