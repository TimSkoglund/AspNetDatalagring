using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class ExternalAuthController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ExternalCallback()
    {
        return View();
    }
}
