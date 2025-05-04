
using Business.Mappers;
using Data.Repositories.Project;

namespace Business.Services.Project;

public class ProjectService(IProjectRepository repo) : IProjectService
{
    public async Task CreateProjectAsync(Models.Project project, CancellationToken cancellation)
    {
        await repo.AddAsync(ProjectMapper.Map(project), cancellation);
    }

    public async Task<List<Models.Project>> GetProjectsAsync(CancellationToken cancellationToken)
    {
        var entities = await repo.GetAsync(cancellationToken);

        if (entities == null || !entities.Any())
            return new List<Models.Project>();

        return ProjectMapper.Map(entities);
    }

    public async Task<Models.Project?> GetProjectByIdAsync(int id, CancellationToken cancellationToken)
    {
        var entity = await repo.GetAsync(x => x.Id == id, cancellationToken);
        return ProjectMapper.Map(entity!);
    }

    // TODO: implementera uppdatering & borttag
    public Task<bool> UpdateProjectAsync(Models.Project c, CancellationToken cancellationToken) => throw new NotImplementedException();
    public Task<bool> DeleteProjectAsync(int id, CancellationToken cancellationToken) => throw new NotImplementedException();
}