using Data.Context;
using Data.Entities;
using Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.User;

public class UserRepository(DataContext ctx)
    : BaseRepository<UserEntity>(ctx), IUserRepository
{
    public async Task<UserEntity?> GetUserAsync(string email, string passwordHash, CancellationToken cancellationToken)
    {
        return await Db.FirstOrDefaultAsync(
            u => u.Email == email && u.Password == passwordHash,
            cancellationToken);
    }
}
