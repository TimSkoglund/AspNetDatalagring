namespace Presentation.Models;

public class ProjectsViewModel
{
    public IEnumerable<ProjectViewModel> Projects { get; set; } = []; //new List<ProjectViewModel>(); <---lösning
    public AddProjectViewModel AddProjectFormData { get; set; } = new();
    public EditProjectViewModel EditProjectFormData { get; set; } = new();
}
