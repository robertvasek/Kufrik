using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using System.Net;
using System.Net.Mail;

using travel_co.Models;

using travel_co.Data;

namespace travel_co.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;

        CountryRepository.Europe.ContinentCountries = CountryRepository.EuropeCountries;
        CountryRepository.Asia.ContinentCountries = CountryRepository.AsiaCountries;

        allCountries.Add(CountryRepository.Europe);
        allCountries.Add(CountryRepository.Asia);
    }

    List<Post> articles = PostRepository.Articles;

    List<Question> questions = QuestionRepository.Questions;

    List<Trip> trips = TripRepository.Trips;

    List<Continent> allCountries = new();

    public IActionResult Index()
    {
        return View(articles);
    }

    public IActionResult Post(int id)
    {
        var article = articles.Find(p => p.Id == id);
        return View(article);
    }

    public IActionResult FandQ()
    {
        return View(questions);
    }

    public IActionResult Zajezdy()
    {
        return View(trips);
    }

    public IActionResult Trip(int id)
    {
        var trip = trips.Find(p => p.Id == id);
        return View(trip);
    }

    public IActionResult Pruvodce()
    {
        return View(allCountries);
    }

    public IActionResult Country(int id)
    {
        var temp_country = new Country();

        foreach (var Continent in allCountries)
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

