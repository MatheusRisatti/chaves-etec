using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using chaves_etec.Models;
using chaves_etec.Services;

namespace chaves_etec.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IChavesService _chavesService;

    public HomeController(ILogger<HomeController> logger, IChavesService chavesService)
    {
        _logger = logger;
        _chavesService = _chavesService;
    }

    public IActionResult Index(string personagem)
    {
        var persos = _chavesService.GetChavesDto();
        ViewData["filter"] = string.IsNullOrEmpty(personagem) ? "all" : personagem;
        return View(persos);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id 
        ?? HttpContext.TraceIdentifier });
    }
}
