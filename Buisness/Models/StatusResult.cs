using Domain.Models;

namespace Buisness.Models;

public class StatusResult<T> : ServiceResult
{
    public T? Result { get; set; }
}

public class StatusResult : ServiceResult
{
}
