namespace Business.Services.Project
{
    public interface IProjectService
    {
        Task CreateProjectAsync(Models.Project project, CancellationToken cancellation);
        Task<bool> DeleteProjectAsync(int id, CancellationToken cancellation);
        Task<Models.Project?> GetProjectByIdAsync(int id, CancellationToken cancellation);
        Task<List<Models.Project>> GetProjectsAsync(CancellationToken cancellation);
        Task<bool> UpdateProjectAsync(Models.Project project, CancellationToken cancellation);
    }
}
