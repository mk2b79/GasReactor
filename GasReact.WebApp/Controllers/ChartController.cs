using GasReact.BLL.DTO;
using Microsoft.AspNetCore.Mvc;

namespace GasReact.WebApp.Controllers;

public class ChartController : Controller
{
    public IActionResult Index()
    {
        List<IndicatorChartDto> records = new List<IndicatorChartDto>
        {
            new IndicatorChartDto { Value = 10, Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = 25, Date = new DateTime(2023, 1, 2) },
            new IndicatorChartDto { Value = 13, Date = new DateTime(2023, 1, 3) },
            new IndicatorChartDto { Value = 32, Date = new DateTime(2023, 1, 4) },
            new IndicatorChartDto { Value = 20, Date = new DateTime(2023, 1, 5) },
            new IndicatorChartDto { Value = 10, Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = 10, Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = 25, Date = new DateTime(2023, 1, 2) },
            new IndicatorChartDto { Value = 13, Date = new DateTime(2023, 1, 3) },
            new IndicatorChartDto { Value = 32, Date = new DateTime(2023, 1, 4) },
            new IndicatorChartDto { Value = 20, Date = new DateTime(2023, 1, 5) },
            new IndicatorChartDto { Value = 10, Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = 25, Date = new DateTime(2023, 1, 2) },
            new IndicatorChartDto { Value = 13, Date = new DateTime(2023, 1, 3) },
            new IndicatorChartDto { Value = 32, Date = new DateTime(2023, 1, 4) },
            new IndicatorChartDto { Value = 20, Date = new DateTime(2023, 1, 5) },
            new IndicatorChartDto { Value = 10, Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = 25, Date = new DateTime(2023, 1, 2) },
            new IndicatorChartDto { Value = 13, Date = new DateTime(2023, 1, 3) },
            new IndicatorChartDto { Value = 32, Date = new DateTime(2023, 1, 4) },
            new IndicatorChartDto { Value = 10, Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = 25, Date = new DateTime(2023, 1, 2) },
            new IndicatorChartDto { Value = 13, Date = new DateTime(2023, 1, 3) },
            new IndicatorChartDto { Value = 32, Date = new DateTime(2023, 1, 4) },
            new IndicatorChartDto { Value = 20, Date = new DateTime(2023, 1, 5) },
            new IndicatorChartDto { Value = 10, Date = new DateTime(2023, 1, 1) },
            new IndicatorChartDto { Value = 25, Date = new DateTime(2023, 1, 2) },
            new IndicatorChartDto { Value = 13, Date = new DateTime(2023, 1, 3) },
            new IndicatorChartDto { Value = 32, Date = new DateTime(2023, 1, 4) },
            new IndicatorChartDto { Value = 20, Date = new DateTime(2023, 1, 5) },
            new IndicatorChartDto { Value = 20, Date = new DateTime(2023, 1, 5) }
        };

        var dataValues = records.Select(r => r.Value).ToList();
        var dateLabels = records.Select(r => r.Date).ToList();

        ViewBag.DataValues = dataValues;
        ViewBag.DateLabels = dateLabels;

        return View();
    }
}