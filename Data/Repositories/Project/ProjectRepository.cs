using Data.Context;
using Data.Entities;
using Data.Repositories.Base;

namespace Data.Repositories.Project;

public class ProjectRepository(DataContext ctx)
    : BaseRepository<ProjectEntity>(ctx), IProjectRepository
{ }
