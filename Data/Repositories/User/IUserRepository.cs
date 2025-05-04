using Data.Entities;
using Data.Repositories.Base;

namespace Data.Repositories.User
{
    public interface IUserRepository : IBaseRepository<UserEntity>
    {
        public Task<UserEntity?> GetUserAsync(string email, string passwordHash, CancellationToken cancellationToken);
    }
}