using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Contracts.Logging;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;

namespace MetroDelivery.Application.Features.Users.Queries.GetUserDetail
{
    public class GetUserDetailQueryHandler : IRequestHandler<GetUserDetailQuery, UserDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IAppLogger<GetUserDetailQueryHandler> _logger;

        public GetUserDetailQueryHandler(IUserRepository userRepository, IMapper mapper, IAppLogger<GetUserDetailQueryHandler> logger)
        {
            this._userRepository = userRepository;
            this._mapper = mapper;
            this._logger = logger;
        }

        public async Task<UserDto> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByEmailAndPassword(request.Email, request.Password);
            var result = _mapper.Map<UserDto>(user);

            if (user == null) {
                throw new NotFoundExcrption(nameof(User), request.Password);
            }

            _logger.LogInformation("successfully");
            return result;
        }
    }
}
