using E_Commerce.Entities;

namespace E_Commerce.Data
{
	public class NewsRepository
	{
		private static List<News> News = new()
		{
			new(){Id = 1, Header = " will vainly look for fruit on it in autumn.", ImagePath= "latest-news/news-bg-1.jpg"},
			new(){Id = 2, Header = "A man's worth has its season, like tomato.",ImagePath= "latest-news/news-bg-2.jpg"},
			new(){Id = 3, Header = "Good thoughts bear good fresh juicy fruit.", ImagePath = "latest-news/news-bg-3.jpg"},
			new(){Id = 4, Header = "Fall in love with the fresh orange", ImagePath = "latest-news/news-bg-4.jpg"},
			new(){Id = 5, Header = "Why the berries always look delecious", ImagePath = "latest-news/news-bg-5.jpg"},
			new(){Id = 6, Header = "Love for fruits are genuine of John Doe", ImagePath = "latest-news/news-bg-6.jpg"}
		};
		public static List<News> GetNews() { return News; }	
	}
}
