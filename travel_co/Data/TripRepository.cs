using System;
namespace travel_co.Data
{
	public class TripRepository
	{
        public static List<Trip> Trips = new List<Trip>
    {
        new Trip { Id = 1, Country = "Západ USA", StartDate = new DateTime(2024, 8, 12), EndDate = new DateTime(2024, 8, 29), Capacity = 20, Price = 47900,
            ShortDescription = "Během zájezdu v USA navštívíme ty nejkrásnější místa a národní parky západu USA. Yosemite, Yellowstone, Grand Canyon, kouřící gejzíry, rudé kaňony a další národní parky a úchvatné scenérie spolu s nejhezčím městem západu San Franciscem, bláznivým Los Angeles, nebo nikdy nespícím Las Vegas. To jsou jedny z mnoha úchvatných míst, které společně během zájezdu po západu USA navštívíme. Jsou to místa, která se Vám nesmazatelně vryjí do paměti na celý život.",
            ImageUrls = new string[] { "/images/grandCanyon.jpeg" } },

        new Trip { Id = 2, Country = "Maledivy", StartDate = new DateTime(2024, 7, 3), EndDate = new DateTime(2024, 7, 17), Capacity = 12, Price = 52700,
                ShortDescription = "Maledivy – ráj na zemi v Indickém oceánu. Splňte si své sny a užijte si dny plné relaxu a pohody na bělostných plážích. Atmosféru plnou exotiky dokreslují vzrostlé palmy lemující tyto krásné ostrovy a azurově modré moře. Pod hladinou můžete obdivovat nádherné korálové útesy, kde žijí nejrůznější druhy pestrobarevných ryb, a vychutnat si pravé podmořské dobrodružství.",
                ImageUrls = new string[] { "/images/maldives.jpeg" } },
    };
    }
}

