using Business.Models;
using Data.Entities;

namespace Business.Mappers;

public static class ProjectMapper
{
    public static ProjectEntity Map(Project project)
    {
        return project != null ? new ProjectEntity
        {
            Name = project.Name,
            Budget = project.Budget,
            CustomerId = project.CustomerId,
            Description = project.Description,
            EndDate = project.EndDate,  
            ProductId = project.ProductId,
            StartDate = project.StartDate,
            StatusId = project.StatusId,
            UserId = project.UserId
        } : null;
    }
    
    public static Project Map(ProjectEntity project)
    {
        return project != null ? new Project
        {
            Id = project.Id,
            Name = project.Name,
            Budget = project.Budget,
            CustomerId = project.CustomerId,
            Description = project.Description,
            EndDate = project.EndDate,
            ProductId = project.ProductId,
            StartDate = project.StartDate,
            StatusId = project.StatusId,
            UserId = project.UserId
        } : null;
    }

    public static List<Project> Map(List<ProjectEntity> projects)
    {
        return projects != null ? projects.Select(Map).ToList() : new List<Project>();
    }
}