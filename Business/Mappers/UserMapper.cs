using Business.Helper;
using Business.Models;
using Business.Services.User;
using Data.Entities;

namespace Business.Mappers;

public static class UserMapper
{
    public static UserEntity Map(User user)
    {
        return user != null ? new UserEntity
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Password = HashHelper.GetHash(user.Password)
        } : null;
    }
    
    public static User Map(UserEntity user)
    {
        return user != null ? new User
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email
        } : null;
    }

    public static UserEntity Map(RegisterUser user)
    {
        return user != null ? new UserEntity
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Password = HashHelper.GetHash(user.Password)
        } : null;
    }
}