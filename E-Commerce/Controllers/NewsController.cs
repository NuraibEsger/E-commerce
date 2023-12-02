using E_Commerce.Data;
using E_Commerce.Entities;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
	public class NewsController : Controller
	{
		List<News> _news;
		public NewsController()
		{
			_news = NewsRepository.GetNews();
		}
		public IActionResult Index()
		{
			NewsIndexVM model = new()
			{
				News = _news
			};
			return View(model);
		}

		public IActionResult Details(int id)
		{
			var news = _news;
			if (news is null) return RedirectToAction("Index", "404");
			var model = new NewsDetailsVM()
			{
				News = news.FirstOrDefault(x => x.Id == id)
			};

			return View(model);
		}
	}
}
