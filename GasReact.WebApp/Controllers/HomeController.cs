using Microsoft.AspNetCore.Mvc;

namespace GasReact.WebApp.Controllers;

public class HomeController:Controller
{
    public IActionResult Index()
    {
        return View();
    }
}