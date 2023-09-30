/*using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;

namespace MetroDelivery.Application.Features.Users.Queries.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, CustomerDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public GetUserByIdQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            this._userRepository = userRepository;
            this._mapper = mapper;
        }

        public async Task<CustomerDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            //add to datbase 
            var userById = await _userRepository.GetByIdAsync(request.id);

            if (userById == null) {
                throw new NotFoundExcrption(nameof(User.UserName), request.id);
            }

            //convert data to dto
            var data = _mapper.Map<CustomerDto>(userById);

            //return
            return data;
        }
    }
}
*/