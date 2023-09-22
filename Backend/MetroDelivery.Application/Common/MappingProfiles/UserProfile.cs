using AutoMapper;
using MetroDelivery.Application.Features.Users;
using MetroDelivery.Application.Features.Users.Commands.CreateUser;
using MetroDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Common.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<CreateUserCommand, User>().ReverseMap();
        }

    }
}
