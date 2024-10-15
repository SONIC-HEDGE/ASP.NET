using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_App.Models;

namespace Web_App.Controllers; //dhdhehdue
//hfeugcvyrgvry

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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

    /*public IActionResult Calculator(Operator? op, double? a, double? b)
    {
        if (a == null || b == null)
        {
            ViewBag.ErrorMessage = "Zły format a lub b";
            return View("CustomError");
        }
        
        if (op is null)
        {
            ViewBag.ErrorMessage = "Zły operator";
            return View("CustomError");
        }
        
        
        ViewBag.a = a;
        ViewBag.b = b;
        switch (op)
        {
            case Operator.Add:
                ViewBag.result = a + b;
                ViewBag.op = "+";
                break;
            case Operator.Sub:
                ViewBag.result = a - b;
                ViewBag.op = "-";
                break;
            case Operator.Mult:
                ViewBag.result = a * b;
                ViewBag.op = "*";
                break;
            case Operator.Div:
                ViewBag.result = a / b;
                ViewBag.op = "/";
                break;
            
        }
        return View();
    }

    public enum Operator
    {
        Add, Sub, Mult, Div
    }*/
}