
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Presentation.Models;

namespace Presentation.Controllers;

public class ProjectsController : Controller
{
    [Route("admin/projects")]
   public IActionResult Index()
    {
        var viewModel = new ProjectsViewModel()
        {
            Projects = SetProjects(),
            AddProjectFormData = new AddProjectViewModel
            {
                Clients = SetClients(),
                Members = SetMembers(),
            },
            EditProjectFormData =new EditProjectViewModel
            {
                Clients = SetClients(),
                Members = SetMembers(),
                Statuses = SetStatuses()
            }
        };

        return View(viewModel);
    }

    private IEnumerable<ProjectViewModel> SetProjects()
    {
        var projects = new List<ProjectViewModel>
        {
            new() {
                Id = Guid.NewGuid().ToString(),
                ProjectName = "Website Redesign",
                ProjectImage = "/images/projects/project-template-purple.svg",
                Description = "<P>It is<Strong>necessary</Strong>to develop a website redesign in a corporate style.</P>",
                ClientName = "Gitlab inc.",
                TimeLeft = "1 week left",
                Members = ["/images/users/user-template-male-green.svg"]

            }
        };

        return projects;
    }

    private IEnumerable<SelectListItem> SetClients() //göra så att det hemtas från databas
    {
        var clients = new List<SelectListItem> {
            new() { Value = "1", Text = "Client 1" },
            new() { Value = "2", Text = "Client 2" },
            new() { Value = "3", Text = "Client 3" }
        };
        return clients;
    }

    private static IEnumerable<SelectListItem> SetMembers()
    {
        var Members = new List<SelectListItem> {
            new() { Value = "1", Text = "Tim Skoglund" },
            new() { Value = "2", Text = "Daniel Toivonen" },
            new() { Value = "3", Text = "Andreas Österlund" }
        };
        return Members;
    }

    private IEnumerable<SelectListItem> SetStatuses()
    {
        var Statuse = new List<SelectListItem> {
            new() { Value = "1", Text = "STARTED", Selected = true },
            new() { Value = "2", Text = "COMPLETED" },
        };
        return Statuse;
    }
}
