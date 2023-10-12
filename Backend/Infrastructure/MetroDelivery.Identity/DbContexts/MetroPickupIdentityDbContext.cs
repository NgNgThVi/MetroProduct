using MediatR;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Contracts.Identity;
using MetroDelivery.Domain.Common;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Domain.IdentityModels;
using MetroDelivery.Identity.DbContexts.Interceptor;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Identity.DbContexts
{
    public class MetroPickupIdentityDbContext : IdentityDbContext<ApplicationUser>, IMetroPickUpDbContext
    {
        /*private readonly IUserService _userService;
        private readonly IMediator _mediator;*/
        private readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;

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
        public DbSet<Store_Menu> Store_Menus { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Trip_Route> Trip_Routes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<WithDraw> WithDraws { get; set; }

        public MetroPickupIdentityDbContext(DbContextOptions<MetroPickupIdentityDbContext> options/*,
            IMediator mediator,
            AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor*/) : base(options)
        {
            /*_mediator = mediator;
            _auditableEntitySaveChangesInterceptor = auditableEntitySaveChangesInterceptor;*/
        }

        /*public MetroPickupIdentityDbContext(IUserService userService)
        {
            _userService = userService;
        }*/

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            builder.ApplyConfigurationsFromAssembly(typeof(MetroPickupIdentityDbContext).Assembly);
            base.OnModelCreating(builder);
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptor);
        }

        /*public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _mediator.DispatchDomainEvents(this);

            return await base.SaveChangesAsync(cancellationToken);
        }*/
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

        public int SaveChanges(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
