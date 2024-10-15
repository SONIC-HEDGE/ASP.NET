using Microsoft.AspNetCore.Mvc;

namespace Web_App.Controllers;

public class CalculatorController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}