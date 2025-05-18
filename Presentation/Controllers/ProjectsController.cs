
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;

namespace Presentation.Controllers;

public class ProjectsController : Controller
{
    [Route("admin/projects")]
   public IActionResult Index()
    {
        var viewModel = new ProjectsViewModel()
        {
            Projects = SetProjects()
        };

        return View(viewModel);
    }

    private IEnumerable<ProjectViewModel> SetProjects()
    {
        var projects = new List<ProjectViewModel>();

        projects.Add(new ProjectViewModel
        {
            Id = Guid.NewGuid(). ToString(),
            ProjectName ="Website Redesign",
            ProjectImage = "/images/projects/project-template.svg",
            Description = "<P>It is<Strong>necessary</Strong>to develop a website redesign in a corporate style.</P>",
            TimeLeft ="1 week left",
            Members = [ "/images/users/user-template-male-green.svg" ]

        });

        return projects;
    }
}
