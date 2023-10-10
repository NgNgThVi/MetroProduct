using AutoMapper;
using MetroDelivery.Application.Features.Customers;
using MetroDelivery.Application.Features.Menu_Product;
using MetroDelivery.Application.Features.Stations;
using MetroDelivery.Application.Features.Stations.Queries;
using MetroDelivery.Application.Features.Stores;
using MetroDelivery.Application.Features.Trips.Queries;
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

            // store
            CreateMap<StoreDto, Store>().ReverseMap();
            CreateMap<Store, StoreDto>().ReverseMap();

            //Menu_Product
            CreateMap<Menu_ProductDto, Menu_Product>().ReverseMap();
            CreateMap<Menu_Product, Menu_ProductDto>().ReverseMap();

            //Station
            CreateMap<StationData, Station>().ReverseMap();
            CreateMap<Station, StationData>().ReverseMap();

            //Store
            CreateMap<StoreData, Store>().ReverseMap();
            CreateMap<Store, StoreData>().ReverseMap();

            //Trip
            CreateMap<TripResponse, Trip>().ReverseMap();
            CreateMap<Trip, TripResponse>().ReverseMap();

            //Trip
            CreateMap<TripDto, Trip>().ReverseMap();
            CreateMap<Trip, TripDto>().ReverseMap();
        }

    }
}
