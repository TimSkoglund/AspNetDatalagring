using Business.Models;
using Data.Entities;

namespace Business.Mappers;

public static class ProjectMapper
{
    public static ProjectEntity Map(Project project)
    {
        return project != null ? new ProjectEntity
        {
            Id = project.Id,
            Title = project.Title
        } : null;
    }
    
    public static Project Map(ProjectEntity project)
    {
        return project != null ? new Project
        {
            Id = project.Id,
            Title = project.Title
        } : null;
    }

    public static List<Project> Map(List<ProjectEntity> projects)
    {
        return projects != null ? projects.Select(Map).ToList() : new List<Project>();
    }
}