namespace Business.Services.User;

public interface IUserService
{
    Task CreateUserAsync(RegisterUser user, CancellationToken cancellationToken);
    Task<bool> LoginAsync(string email, string password, CancellationToken cancellationToken);
}