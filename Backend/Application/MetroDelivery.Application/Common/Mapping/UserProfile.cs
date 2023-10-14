using AutoMapper;
using MetroDelivery.Application.Features.Categorys.Queries;
using MetroDelivery.Application.Features.Customers;
using MetroDelivery.Application.Features.Menu_Products;
using MetroDelivery.Application.Features.Menus.Queries;
using MetroDelivery.Application.Features.OrderDetails.Queries;
using MetroDelivery.Application.Features.PaymentMethods.Queries;
using MetroDelivery.Application.Features.Products.Queries;
using MetroDelivery.Application.Features.Routes.Queries;
using MetroDelivery.Application.Features.Stations;
using MetroDelivery.Application.Features.Stations.Queries;
using MetroDelivery.Application.Features.Store_Menus.Queries;
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
            CreateMap<MenuProductResponse, Menu_Product>().ReverseMap();
            CreateMap<Menu_Product, MenuProductResponse>().ReverseMap();

            //Station
            CreateMap<StationData, Station>().ReverseMap();
            CreateMap<Station, StationData>().ReverseMap();

            //Store
            CreateMap<StoreData, Store>().ReverseMap();
            CreateMap<Store, StoreData>().ReverseMap();

            //Trip
            CreateMap<TripResponse, Trip>().ReverseMap();
            CreateMap<Trip, TripResponse>().ReverseMap();
            
            //Route
            CreateMap<RouteData, Route>().ReverseMap();
            CreateMap<Route, RouteData>().ReverseMap();
            //Route
            CreateMap<RouteResponse, Route>().ReverseMap();
            CreateMap<Route, RouteResponse>().ReverseMap();

            //Product
            CreateMap<ProductResponse, Product>().ReverseMap();
            CreateMap<Product, ProductResponse>().ReverseMap();

            //Category
            CreateMap<CategoryResponse, Category>().ReverseMap();
            CreateMap<Category, CategoryResponse>().ReverseMap();

            //Order
            CreateMap<OrderData, Order>().ReverseMap();
            CreateMap<Order, OrderData>().ReverseMap();

            //Product
            CreateMap<ProductData, Product>().ReverseMap();
            CreateMap<Product, ProductData>().ReverseMap();

            //Menu
            CreateMap<MenuResponse, Menu>().ReverseMap();
            CreateMap<Menu, MenuResponse>().ReverseMap();

            //Store_Menu
            CreateMap<MenuData, Menu>().ReverseMap();
            CreateMap<Menu, MenuData>().ReverseMap();

            //PaymentMEdthod
            CreateMap<PaymentMethodResponse, PaymentMethod>().ReverseMap();
            CreateMap<PaymentMethod, PaymentMethodResponse>().ReverseMap();

        }

    }
}
