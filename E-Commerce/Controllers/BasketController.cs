using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
	public class BasketController : Controller
	{
		public IActionResult AddtoBasket(int id)
		{
			Console.WriteLine(id);
			return RedirectToAction("Details","Shops");
		}
	}
}
