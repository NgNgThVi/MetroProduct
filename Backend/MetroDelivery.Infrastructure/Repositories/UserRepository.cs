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

        public async Task CreateUser(User user)
        {
            var entity = new User();
            entity.UserName = user.UserName;
            entity.Email = user.Email;
            entity.Password = user.Password;
            entity.Role = user.Role;
            entity.Phone = user.Phone;
            entity.Address = user.Address;

            _metroDeliveryDatabaseContext.Add(entity);
            await _metroDeliveryDatabaseContext.SaveChangesAsync();
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
