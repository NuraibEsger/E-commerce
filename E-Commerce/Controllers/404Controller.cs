using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
	public class _404Controller : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
