using Domain.Models;

namespace Buisness.Models;

public class UserResult : ServiceResult
{
    public IEnumerable<User>? Result { get; set; }
}
