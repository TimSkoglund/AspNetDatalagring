using Buisness.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;

namespace Presentation.Controllers;

public class ProjectsController(IProjectService projectService) : Controller
{
    private readonly IProjectService _projectService = projectService;

    public async Task<IActionResult> Index()
    {
        var model = new ProjectViewModel
        {
            Projects = await _projectService.GetProjectsAsync(),
        };
        return View(model);
    }


    [HttpPost]
    public async Task<IActionResult> Add(AddProjectViewModel)
    {
        var addProjectFormData = model.MapTo<AddProjectFormData>();
        var result = await _projectService.CreateProjectAsync(addProjectFormData);

        return Json(new { });
    }


    [HttpPost]
    public IActionResult Update(EditProjectViewModel)
    {
        return Json(new { });
    }


    [HttpPost]
    public IActionResult Delete(String id)
    {
        return Json(new {});
    }
}
