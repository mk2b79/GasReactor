using GasReact.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace GasReact.WebApp.Controllers;

public class RecordsController:Controller
{
    private readonly RecordServices _recordServices;

    public RecordsController(RecordServices recordServices)
    {
        _recordServices = recordServices;
    }

    public IActionResult Index()
    {
        var records = _recordServices.GetAllRecordAsync().Result;
        return View(records);
    }
    
}