using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Common.Interface
{
    public interface IMetroPickUpDbContext
    {
        DbSet<Category> Categories { get; }
        DbSet<Menu> Menus { get; }
        DbSet<Menu_Product> Menu_Products { get; }
        DbSet<Order> Orders { get; }
        DbSet<OrderDetail> OrderDetails { get; }
        DbSet<PaymentMethod> PaymentMethods { get; }
        DbSet<Product> Products { get; }
        DbSet<Route> Routes { get; }
        DbSet<Route_Station> Route_Stations { get; }
        DbSet<Station> Stations { get; }
        DbSet<Store> Stores { get; }
        DbSet<Trip> Trips { get; }
        DbSet<Trip_Route> Trip_Routes { get; }
        DbSet<Customer> Customers { get; }
        DbSet<WithDraw> WithDraws { get; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        public int SaveChanges(CancellationToken cancellationToken = default);

    }
}
