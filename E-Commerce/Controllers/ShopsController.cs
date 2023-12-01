using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
	public class ShopsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
