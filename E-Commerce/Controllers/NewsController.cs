using E_Commerce.Data;
using E_Commerce.Entities;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
	public class NewsController : Controller
	{
		public IActionResult Index()
		{
			NewsIndexViewModel model = new()
			{
				News = NewsRepository.GetNews()
			};
			return View(model);
		}
	}
}
