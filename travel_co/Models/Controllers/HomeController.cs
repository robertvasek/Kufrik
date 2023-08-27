using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using System.Net;
using System.Net.Mail;

using travel_co.Models;

namespace travel_co.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;

        Europe.Name = "Evropa";
        Europe.ContinentCountries = EuropeCountries;

        Asia.Name = "Asie";
        Asia.ContinentCountries = AsiaCountries;

        AllCountries.Add(Europe);
        AllCountries.Add(Asia);
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
        new Question { QuestionQ = "Do kdy můžu zrušit svou rezervaci na zájezd?", AnswerQ = "Rezervaci je možné bezplatně zrušit do zaplacení první zálohy, která bývá zpravidla dva měsíce před začátkem zájezdu." },
        new Question { QuestionQ = "Je potřebné si koupit pojištění na zájezd?", AnswerQ = "Ne, není. Pojištění zajišťujeme hromadně pro všechny účastníky zájezdu a je tak součástí ceny zájezdu." },
    };

    public IActionResult FandQ()
    {
        return View(Questions);
    }

    private List<Trip> Trips = new List<Trip>
    {
        new Trip { Id = 1, Country = "Západ USA", StartDate = new DateTime(2024, 8, 12), EndDate = new DateTime(2024, 8, 29), Capacity = 20, Price = 47900, ShortDescription = "Světoznámé metropole jako Los Angeles, San Francisco nebo pozoruhodné zákruty Grand Canyonu?",
        ImageUrls = new string[] { "/images/grandCanyon.jpeg" } },
        new Trip { Id = 2, Country = "Maledivy", StartDate = new DateTime(2024, 7, 3), EndDate = new DateTime(2024, 7, 17), Capacity = 12, Price = 52700, ShortDescription = "Šumění palm, piskot delfínů a dehberoucí potápění...to vše na Maledivách",
        ImageUrls = new string[] { "/images/maldives.jpeg" } },
    };

    public IActionResult Zajezdy()
    {
        return View(Trips);
    }

    public IActionResult Trip(int id)
    {
        var trip = Trips.Find(p => p.Id == id);
        return View(trip);
    }

    private List<Country> EuropeCountries = new List<Country>
    {
        new Country { Id = 101,  Name = "Česká republika", Capital = "Praha", Currency = "Koruna česká", CountryLanguage = Language.Čeština, Population = 10827529, Area = 78871, ImageUrls = new string[] { "/images/prague.jpeg"} },
        new Country { Id = 102, Name = "Slovensko", Capital = "Bratislava", Currency = "Euro", CountryLanguage = Language.Slovenčina, Population = 5460185, Area = 49035, ImageUrls = new string[] { "/images/slovakia.jpeg"} },
        new Country { Id = 103, Name = "Německo", Capital = "Berlín", Currency = "Euro", CountryLanguage = Language.Němčina, Population = 84432670, Area = 357592, ImageUrls = new string[] { "/images/germany.jpeg"} },
        new Country { Id = 104, Name = "Španělsko", Capital = "Madrid", Currency = "Euro", CountryLanguage = Language.Španělština, Population = 48958159, Area = 504782, ImageUrls = new string[] { "/images/spain.jpeg"} },
        new Country { Id = 105, Name = "Maďarsko", Capital = "Budapešt", Currency = "Euro", ImageUrls = new string[] { "/images/hungary.jpeg"} }
    };

    private List<Country> AsiaCountries = new List<Country>
    {
        new Country { Id = 201, Name = "Čína", Capital = "Peking", Currency = "Juan", CountryLanguage = Language.Čínština, Population = 1425745995, Area = 9596960, ImageUrls = new string[] { "/images/china.jpeg" } }
    };

    private Continent Europe = new();
    private Continent Asia = new();

    private List<Continent> AllCountries = new();

    public IActionResult Pruvodce()
    {
        return View(AllCountries);
    }

    public IActionResult Country(int id)
    {
        var temp_country = new Country { Id = 0 };

        foreach (var Continent in AllCountries)
        {
            foreach(var Country in Continent.ContinentCountries)
            {
                if (Country.Id == id)
                {
                    temp_country = Country;
                    goto found;
                }
            }
        }
        found:
            return View(temp_country);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

