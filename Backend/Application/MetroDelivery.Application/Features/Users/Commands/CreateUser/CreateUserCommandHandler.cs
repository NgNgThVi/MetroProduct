using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        

        public CreateUserCommandHandler(IMapper mapper, IUserRepository userRepository)
        {
            this._mapper = mapper;
            this._userRepository = userRepository;
        }

        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            // validate incoming data
            var validator = new CreateUserCommandValidator(_userRepository);
            var validatorResult = await validator.ValidateAsync(request);
            if(validatorResult.Errors.Any()) {
                throw new BadRequestException("Invalid Create user", validatorResult);
            }
            
            // convert domain entity object
            var userCreate = _mapper.Map<User>(request);

            // add to database
            await _userRepository.CreateAsync(userCreate);

            // return record id
            return userCreate.Id;
        }

    }
}
