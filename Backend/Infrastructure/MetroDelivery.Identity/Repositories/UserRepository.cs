using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Identity.DbContext;
using Microsoft.EntityFrameworkCore;

namespace MetroDelivery.Identity.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(MetroPickupIdentityDbContext metroDeliveryDatabaseContext) : base(metroDeliveryDatabaseContext)
        {
        }

        public async Task<User> GetUserByEmailAndPassword(string email, string password)
        {
            var user = await _metroDeliveryDatabaseContext.Users.Where(x => x.Email == email && x.Password == password).SingleOrDefaultAsync();
            if (user == null) {
                throw new NotFoundExcrption(nameof(User), email);
            }
            return user;
        }

        public async Task<bool> IsUserEmailUnique(string email)
        {
            return await _metroDeliveryDatabaseContext.Users.AnyAsync(x => x.Email == email) == false;
        }

        public async Task<bool> UserIdMusBeExist(Guid id)
        {
            return await _metroDeliveryDatabaseContext.Users.AnyAsync(x => x.Id == id) == false;
        }
    }
}
