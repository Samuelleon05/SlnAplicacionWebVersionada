using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AplicacionWebVersionada.Models;

namespace AplicacionWebVersionada.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="logger">Este es ejemplo de clase</param>
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    /// <summary>
    /// Ejemplo de la clase
    /// </summary>
    /// <returns> View </returns>

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
