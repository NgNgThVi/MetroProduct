using AutoMapper;
using MediatR;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Users.Queries.GetAllUsers
{
    public class GetListUserQueryHandler : IRequestHandler<GetListUserQuery, List<UserDto>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetListUserQueryHandler(IMapper mapper, IUserRepository userRepository)
        {
            this._mapper = mapper;
            this._userRepository = userRepository;
        }

        public async Task<List<UserDto>> Handle (GetListUserQuery request, CancellationToken cancellationToken)
        {
            // query the database
            var users = await _userRepository.GetAsync();

            // convert data objects to Dto objects
            var data = _mapper.Map<List<UserDto>>(users);

            // return list of Dto object
            return data;
        }
    }
}
