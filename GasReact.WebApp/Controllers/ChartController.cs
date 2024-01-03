using GasReact.BLL.DTO;
using GasReact.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace GasReact.WebApp.Controllers;

public class ChartController : Controller
{
    private ChartServices _chartServices;
    public ChartController(ChartServices chartServices)
    {
        _chartServices = chartServices;
    }
    public IActionResult Index()
    {
        var records = _chartServices.GetRangeAsync(1, 1, 
            new DateTime(), new DateTime()).Result;

        var dataValues = records.Select(r => r.Value).ToList();
        var dateLabels = records.Select(r => r.Date).ToList();

        ViewBag.DataValues = dataValues;
        ViewBag.DateLabels = dateLabels;

        return View();
    }
}