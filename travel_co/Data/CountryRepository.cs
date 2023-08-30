using System;
namespace travel_co.Data
{
	public class CountryRepository
    {

        public static Continent Europe = new()
        {
            Name = "Evropa"
        };

        public static Continent Asia = new()
        {
            Name = "Asie"
        };

        public static List<Country> EuropeCountries = new List<Country>
        {
            new Country { Id = 101,  Name = "Česká republika", Capital = "Praha", Currency = "Koruna česká", CountryLanguage = Language.Čeština,
                Population = 10827529, Area = 78871, ImageUrls = new string[] { "/images/prague.jpeg"} },

            new Country { Id = 102, Name = "Slovensko", Capital = "Bratislava", Currency = "Euro", CountryLanguage = Language.Slovenčina,
                Population = 5460185, Area = 49035, ImageUrls = new string[] { "/images/slovakia.jpeg"} },

            new Country { Id = 103, Name = "Německo", Capital = "Berlín", Currency = "Euro", CountryLanguage = Language.Němčina,
                Population = 84432670, Area = 357592, ImageUrls = new string[] { "/images/germany.jpeg"} },

            new Country { Id = 104, Name = "Španělsko", Capital = "Madrid", Currency = "Euro", CountryLanguage = Language.Španělština,
                Population = 48958159, Area = 504782, ImageUrls = new string[] { "/images/spain.jpeg"} },

            new Country { Id = 105, Name = "Maďarsko", Capital = "Budapešt", Currency = "Euro", CountryLanguage = Language.Maďarština,
                Population = 9712887, Area = 93036, ImageUrls = new string[] { "/images/hungary.jpeg"} }
        };

        public static List<Country> AsiaCountries = new List<Country>
        {
            new Country { Id = 201, Name = "Čína", Capital = "Peking", Currency = "Juan", CountryLanguage = Language.Čínština,
                Population = 1425745995, Area = 9596960, ImageUrls = new string[] { "/images/china.jpeg" } },

            new Country { Id = 202, Name = "Japonsko", Capital = "Tokio", Currency = "Jen", CountryLanguage = Language.Japonština,
                Population = 126146099, Area = 377974, ImageUrls = new string[] { "/images/japan.jpeg" } }
        };
    }
}

