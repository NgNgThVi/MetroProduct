using MetroDelivery.Domain.Common;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Domain.IdentityModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Identity.DbContext
{
    public class MetroPickupIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public MetroPickupIdentityDbContext(DbContextOptions<MetroPickupIdentityDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(MetroPickupIdentityDbContext).Assembly);
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

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseAuditableEntity>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified)) {
                entry.Entity.LastModified = DateTime.Now;
                if (entry.State == EntityState.Added) {
                    entry.Entity.Created = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
