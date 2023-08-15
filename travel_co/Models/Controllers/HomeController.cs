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

    public IActionResult Index()
    {
        return View(articles);
    }

    public IActionResult Post(int id)
    {
        var article = articles.Find(p => p.Id == id);
        return View(article);
    }

    private List<Question> Questions = new List<Question>
    {
        new Question { QuestionQ = "Jak zjistím veškeré podrobné info o daném zájezdu?", AnswerQ = "Veškeré podrobné info je dostupné v .pdf souboru, který je dostupný po zaplacení první zálohy." },
        new Question { QuestionQ = "Do kdy můžu zrušit svou rezervaci na zájezd?", AnswerQ = "Rezervaci je možné bezplatně zrušit do zaplacení první zálohy." },
        new Question { QuestionQ = "Je potřebné si koupit pojištění na zájezd?", AnswerQ = "Ne, není. Pojištění zajišťujeme hromadně pro všechny účastníky zájezdu a je tak součástí ceny zájezdu." },
    };

    public IActionResult Privacy()
    {
        return View(Questions);
    }

    private List<Trip> Trips = new List<Trip>
    {
        new Trip { Country = "Západ USA", StartDate = new DateTime(2024, 8, 12), EndDate = new DateTime(2024, 8, 29), Capacity = 20, Price = 47900, ShortDescription = "Los Angeles, San Francisco nebo třeba Grand Canyon?" },
        new Trip { Country = "Maledivy", StartDate = new DateTime(2024, 7, 3), EndDate = new DateTime(2024, 7, 17), Capacity = 12, Price = 52700, ShortDescription = "Dehberoucí potápění na Maledivách" },
    };

    public IActionResult Zajezdy()
    {
        return View(Trips);
    }

    public IActionResult Pruvodce()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

