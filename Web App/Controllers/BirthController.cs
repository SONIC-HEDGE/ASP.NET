using Microsoft.AspNetCore.Mvc;
using Web_App.Models;

namespace Web_App.Controllers;

public class BirthController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Result([FromForm] Birth model)
    {
        if (!model.isValid())
        {
            ViewBag.ErrorMessage = "Brak imienia";
            return View("CustomError");
        }

        if (model.Years < 0)
        {
            ViewBag.ErrorMessage = "nie możesz mieć przyszłej daty urodzenia";
            return View("CustomError");
        }
        return View(model);
    }
    public IActionResult Form()
    {
        return View();
    }
    
}