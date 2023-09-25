using AutoMapper;
using MediatR;
using MetroDelivery.Application.Contracts.Persistance;

namespace MetroDelivery.Application.Features.Users.Queries.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public GetUserByIdQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            this._userRepository = userRepository;
            this._mapper = mapper;
        }

        public async Task<UserDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            //add to datbase 
            var userById = await _userRepository.GetByIdAsync(request.id);

            //convert data to dto
            var data = _mapper.Map<UserDto>(userById);

            //return
            return data;
        }
    }
}
