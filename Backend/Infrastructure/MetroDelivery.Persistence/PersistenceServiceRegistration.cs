using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Persistence.DatabaseContext;
using MetroDelivery.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MetroDeliveryDatabaseContext>(option =>
            { 
                option.UseSqlServer(configuration.GetConnectionString("MetroDeliveryConnectionString"));
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IMenuProductRepository, MenuProductRepository>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IRouteRepository, RouteRepository>();
            services.AddScoped<IRouteStationRepository, RouteStationRepository>();
            services.AddScoped<IStationRepository, StationRepository>();
            services.AddScoped<ITripRouteRepository, TripRouteRepository>();
            services.AddScoped<IStoreRepository, StoreRepository>();
            services.AddScoped<ITripRepository, TripRepository>();
            services.AddScoped<IWithDrawRepository, WithDrawRepository>();

            return services;
        }
    }
}
