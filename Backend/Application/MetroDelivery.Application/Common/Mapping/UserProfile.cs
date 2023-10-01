using AutoMapper;
using MetroDelivery.Application.Features.Customers;
using MetroDelivery.Domain.Entities;

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
