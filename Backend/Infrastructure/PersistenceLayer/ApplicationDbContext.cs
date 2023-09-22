using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.PersistenceLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

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
        public DbSet<User> Users { get; set; }
        public DbSet<WithDraw> WithDraws { get; set; }
    }
}
