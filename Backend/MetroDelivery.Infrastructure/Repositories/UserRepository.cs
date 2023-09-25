using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace MetroDelivery.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(MetroDeliveryDatabaseContext metroDeliveryDatabaseContext) : base(metroDeliveryDatabaseContext)
        {
        }

        public async Task<User> GetUserByEmailAndPassword(string email, string password)
        {
            var user = await _metroDeliveryDatabaseContext.Users.Where(x => x.Email == email && x.Password == password).SingleOrDefaultAsync();
            if (user == null)
            {
                throw new Exception("Entity not found");
            }
            return user;
        }
    }
}
