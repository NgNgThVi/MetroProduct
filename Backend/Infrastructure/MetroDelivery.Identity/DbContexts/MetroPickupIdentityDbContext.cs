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
        private readonly IUserService _userService;
        private readonly IMediator _mediator;
        private readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;

        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Menu> Menus => Set<Menu>();
        public DbSet<Menu_Product> Menu_Products => Set<Menu_Product>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderDetail> OrderDetails => Set<OrderDetail>();
        public DbSet<PaymentMethod> PaymentMethods => Set<PaymentMethod>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Route> Routes => Set<Route>();
        public DbSet<Route_Station> Route_Stations => Set<Route_Station>();
        public DbSet<Station> Stations => Set<Station>();
        public DbSet<Store> Stores => Set<Store>();
        public DbSet<Trip> Trips => Set<Trip>();
        public DbSet<Trip_Route> Trip_Routes => Set<Trip_Route>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<WithDraw> WithDraws => Set<WithDraw>();

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

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _mediator.DispatchDomainEvents(this);

            return await base.SaveChangesAsync(cancellationToken);
        }

        public int SaveChanges(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
