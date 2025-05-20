using Data.Contexts;
using Data.Entities;
using Domain.Models;

namespace Data.Repositories;

public interface IStatusRepository : IBaseRepository<StatusEntety, Status>
{
}

public class StatusRepository(AppDbContext context) : BaseRepository<StatusEntety, Status>(context), IStatusRepository
{
}
