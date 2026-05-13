using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp02_Moguelevsky_Sisro.Models;

namespace Tp02_Moguelevsky_Sisro.Controllers;

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

    public IActionResult SugeridorReceta(SugeridorReceta SugeridorReceta)
    {
        ViewBag.Nombre=SugeridorReceta.Nombre;
        ViewBag.FechaNacimiento=SugeridorReceta.FechaNacimiento;
        ViewBag.TipoDeComida=SugeridorReceta.TipoDeComida;
        ViewBag.Presupuesto=SugeridorReceta.Presupuesto;
        ViewBag.cantidadComensales=SugeridorReceta.cantidadComensales;
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
