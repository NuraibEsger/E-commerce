using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
	public class SingleNewsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
