using AutoMapper;
using MetroDelivery.Application.Features.Users;
using MetroDelivery.Application.Features.Users.Commands.CreateUser;
using MetroDelivery.Application.Features.Users.Commands.UpdateUser;
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
            CreateMap<CustomerDto, Customer>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            /*CreateMap<CreateCustomerCommand, User>().ReverseMap();
            CreateMap<UpdateUserCommand, User>().ReverseMap();*/
        }

    }
}
