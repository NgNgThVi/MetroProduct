using MetroDelivery.Domain.Entities;

namespace MetroDelivery.Application.Contracts.Persistance
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetUserByEmailAndPassword(string email, string password);
        Task<bool> IsUserEmailUnique(string email);
        Task<bool> UserIdMusBeExist(Guid id);
    }

}
