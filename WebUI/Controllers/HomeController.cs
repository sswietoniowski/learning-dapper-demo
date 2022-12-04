using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BusinessLogic.Services;
using WebUI.Models;

namespace WebUI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IService _service;

    public HomeController(ILogger<HomeController> logger, IService service)
    {
        _logger = logger;
        _service = service;
    }

    public IActionResult Index()
    {
        var projects = _service.GetAllProjects();

        return View(projects);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}