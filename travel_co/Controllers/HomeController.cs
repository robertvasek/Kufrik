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

    private List<Post> articles = new List<Post>
    {
        new Post { Id = 1, Title = "Rumunsko", StartDate = new DateTime(2023, 4, 3), EndDate = new DateTime(2023, 4, 12), Subtitle = "Transylvánské království odhaleno",
            Content = "Časně z rána jsme nasedli do 7mi místné dodávky a vydali se směrem Flughafen Wien", ImageUrls = new string[] { "/images/romania001.jpg", "/images/romania2.jpg" } },
        new Post { Id = 2, Title = "Slovensko", StartDate = new DateTime(2023, 8, 13), EndDate = new DateTime(2023, 8, 17),  Subtitle = "U bratří na návštěvě v Tatrách", Content = "This is the content of Post 2.", ImageUrls = new string[] { "/images/slovakia01.jpeg" } },
    };

    private List<Question> questions = new List<Question>
    {
        new Question { QuestionQ = "Jak zjistím veškeré podrobné info o daném zájezdu?", AnswerQ = "Veškeré podrobné info je dostupné v .pdf souboru, který je dostupný po zaplacení první zálohy." },
        new Question { QuestionQ = "Do kdy můžu zrušit svou rezervaci na zájezd?", AnswerQ = "Rezervaci je možné bezplatně zrušit do zaplacení první zálohy."},
    };

    public IActionResult Index()
    {
        return View(articles);
    }

    public IActionResult Post(int id)
    {
        var article = articles.Find(p => p.Id == id);
        return View(article);
    }

    public IActionResult Privacy()
    {
        return View(questions);
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

