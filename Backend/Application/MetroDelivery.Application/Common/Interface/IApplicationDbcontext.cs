using MetroDelivery.Domain.Common;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MetroDelivery.Application.Common.Interface
{
    public interface IApplicationDbcontext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Menu_Product> Menu_Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Route_Station> Route_Stations { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Trip_Route> Trip_Routes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<WithDraw> WithDraws { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        public int SaveChanges(CancellationToken cancellationToken = default);  
    }
}
