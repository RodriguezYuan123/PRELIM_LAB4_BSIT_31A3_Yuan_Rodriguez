using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem_Rodriguez.Controllers;

public class LibraryController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}