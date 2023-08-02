using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using travel_co.Models;

namespace travel_co.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    private List<Post> posts = new List<Post>
    {
        new Post { Id = 1, Title = "Rumunsko", Subtitle = "Transylvánské království odhaleno",
            Content = "Časně z rána jsme nasedli do 7mi místné dodávky a vydali se směrem Flughafen Wien" },
        new Post { Id = 2, Title = "Slovensko", Subtitle = "U bratří na návštěvě v Tatrách", Content = "This is the content of Post 2." },
    };

    public IActionResult Index()
    {
        return View(posts);
    }

    public IActionResult Post(int id)
    {
        var post = posts.Find(p => p.Id == id);
        return View(post);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Zájezdy()
    {
        return View();
    }

    public IActionResult Průvodce()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

