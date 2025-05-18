using Microsoft.AspNetCore.Mvc.Rendering;

namespace Presentation.Models;

public class ProjectViewModel
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string ProjectName { get; set; } = null!;
    public string ProjectImage { get; set; } = null!;
    public string ProjectDescription { get; set; } = null!;
    public string TimeLeft { get; set; } = null!;
    public IEnumerable<String> Members { get; set; } = [];

}
