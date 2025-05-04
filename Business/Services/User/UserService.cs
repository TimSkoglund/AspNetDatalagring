using Business.Helper;
using Business.Mappers;
using Data.Repositories.User;

namespace Business.Services.User;

public class UserService(IUserRepository userRepository) : IUserService
{
    public async Task CreateUserAsync(RegisterUser user, CancellationToken cancellationToken)
    {
        // TODO Implementera mer verifiering, kollar endast om det är lika
        if (user.Password != user.PasswordVerify)
            throw new Exception("Lösenorden matchar inte");

        await userRepository.AddAsync(UserMapper.Map(user), cancellationToken);
    }

    public async Task<bool> LoginAsync(string email, string password, CancellationToken cancellationToken)
    {
        var passwordHash = HashHelper.GetHash(password);
        
        var user =  await userRepository.GetUserAsync(
            email, passwordHash, cancellationToken);
        
        return user != null;
    }
}