using Data.Contexts;
using Data.Entities;
using Domain.Models;

namespace Data.Repositories;

public interface IProjectRepository : IBaseRepository<ProjectEntety, Project>
{
}

public class ProjectRepository(AppDbContext context) : BaseRepository<ProjectEntety, Project>(context), IProjectRepository
{
}
