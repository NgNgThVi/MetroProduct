using AutoMapper;
using MediatR;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;

namespace MetroDelivery.Application.Features.Users.Queries.GetUserDetail
{
    public class GetUserDetailQueryHandler : IRequestHandler<GetUserDetailQuery, UserDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetUserDetailQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDto> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByEmailAndPassword(request.Email, request.Password);
            var result = _mapper.Map<UserDto>(user);
            return result;
        }
    }
}
