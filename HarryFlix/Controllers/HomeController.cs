using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HarryFlix.Models;
using HarryFlix.Data;
using Microsoft.EntityFrameworkCore;

namespace HarryFlix.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var movies = _context.Movies
            .Include(m => m.Genres)
            .ThenInclude(mg => mg.Genre)
            .ToList();
        return View(movies);
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
}
