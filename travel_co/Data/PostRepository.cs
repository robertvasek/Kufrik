using System;

namespace travel_co.Data
{
	public class PostRepository
	{
        public static List<Post> Articles = new List<Post>
        {
            new Post { Id = 1, Title = "Rumunsko", StartDate = new DateTime(2023, 4, 3), EndDate = new DateTime(2023, 4, 12), Subtitle = "Transylvánské království odhaleno",
                Content = "Časně z rána jsme nasedli do 7mi místné dodávky a vydali se směrem Flughafen Wien", ImageUrls = new string[] { "/images/romania001.jpg", "/images/romania2.jpg" } },
            new Post { Id = 2, Title = "Slovensko", StartDate = new DateTime(2023, 8, 13), EndDate = new DateTime(2023, 8, 17),  Subtitle = "U bratří na návštěvě v Tatrách", Content = "This is the content of Post 2.", ImageUrls = new string[] { "/images/slovakia01.jpeg" } },
        };
    }
}

