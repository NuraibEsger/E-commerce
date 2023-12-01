using E_Commerce.Entities;

namespace E_Commerce.Data
{
	public class NewsRepository
	{
		private static List<News> News = new()
		{
			new(){Id = 1, Header = " will vainly look for fruit on it in autumn."},
			new(){Id = 2, Header = "A man's worth has its season, like tomato."},
			new(){Id = 3, Header = "Good thoughts bear good fresh juicy fruit."},
			new(){Id = 4, Header = "Fall in love with the fresh orange"},
			new(){Id = 5, Header = "Why the berries always look delecious"},
			new(){Id = 6, Header = "Love for fruits are genuine of John Doe"}

		};
		public static List<News> GetNews() { return News; }	
	}
}
