using Domain.Models;

namespace Buisness.Models;

public class ClientResult : ServiceResult
{
    public IEnumerable<Client>? Result { get; set; }
}

