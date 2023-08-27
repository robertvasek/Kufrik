using System;
namespace travel_co.Data
{
	public class TripRepository
	{
        public static List<Trip> Trips = new List<Trip>
    {
        new Trip { Id = 1, Country = "Západ USA", StartDate = new DateTime(2024, 8, 12), EndDate = new DateTime(2024, 8, 29), Capacity = 20, Price = 47900, ShortDescription = "Světoznámé metropole jako Los Angeles, San Francisco nebo pozoruhodné zákruty Grand Canyonu?",
        ImageUrls = new string[] { "/images/grandCanyon.jpeg" } },
        new Trip { Id = 2, Country = "Maledivy", StartDate = new DateTime(2024, 7, 3), EndDate = new DateTime(2024, 7, 17), Capacity = 12, Price = 52700, ShortDescription = "Šumění palm, piskot delfínů a dehberoucí potápění...to vše na Maledivách",
        ImageUrls = new string[] { "/images/maldives.jpeg" } },
    };
    }
}

