
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
            Projects = [new()]
        };

        return View(viewModel);
    }
}
