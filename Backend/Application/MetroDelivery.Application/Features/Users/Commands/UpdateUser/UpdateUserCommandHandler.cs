using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Contracts.Logging;
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
        private readonly IAppLogger<UpdateUserCommandHandler> _logger;
        public UpdateUserCommandHandler(IMapper mapper, IUserRepository userRepository, IAppLogger<UpdateUserCommandHandler> logger)
        {
            this._mapper = mapper;
            this._userRepository = userRepository;
            this._logger = logger;
        }

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            // validate incoming data
            /*var user = await _userRepository.GetByIdAsync(request.Id);*/
            var validator = new UpdateUserCommandValidator(_userRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any()) {
                _logger.LogWarning("Validation errors in update for {0} - {1}", nameof(User), request.Id);
                throw new BadRequestException("Invalid User", validationResult);
            }
            /*user.UserName = request.NewUserName;
            user.Password = request.NewPassword;
            user.Email = request.NewEmail;
            user.Role = request.NewRole;
            user.Address = request.NewAddress;*/

            // convert to domain entity object
            var userUpdate = _mapper.Map<User>(request);

            // add database
            await _userRepository.UpdateAsync(userUpdate);


            // return
            return Unit.Value;
        }
    }
}
