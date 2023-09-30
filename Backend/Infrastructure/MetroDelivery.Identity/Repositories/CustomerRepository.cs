using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Application.Features.Users;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Domain.IdentityModels;
using MetroDelivery.Identity.DbContext;
using Microsoft.EntityFrameworkCore;

namespace MetroDelivery.Identity.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        
        public CustomerRepository(MetroPickupIdentityDbContext metroDeliveryDatabaseContext) : base(metroDeliveryDatabaseContext)
        {
            
        }

        public async Task<bool> IsCustomerEmailUnique(string email)
        {
            return await _metroDeliveryDatabaseContext.Customers.AllAsync(x => x.ApplicationUser.Email == email) == false;
        }

        public async Task<Customer> CustomerIdMusBeExist(Guid id)
        {
            return await _metroDeliveryDatabaseContext.Customers.Include(q => q.ApplicationUser).FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task<bool> IsBeUniqueCustomerName(string customerName)
        {
            return await _metroDeliveryDatabaseContext.Customers.AllAsync(x => x.ApplicationUser.UserName == customerName) == false;
        }
    }
}
