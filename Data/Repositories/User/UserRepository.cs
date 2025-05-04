using Data.Context;
using Data.Entities;
using Data.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.User;

public class UserRepository(DataContext ctx)
    : BaseRepository<UserEntity>(ctx), IUserRepository
{
    public async Task<UserEntity?> GetUserAsync(string email, CancellationToken cancellationToken)
    {
        return await Db.FirstOrDefaultAsync(
            u => u.Email == email,
            cancellationToken);
    }
}
