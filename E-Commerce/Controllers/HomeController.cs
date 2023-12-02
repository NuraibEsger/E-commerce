using E_Commerce.Data;
using E_Commerce.Entities;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_Commerce.Controllers
{
	public class HomeController : Controller
	{
		List<Product> _products;
		public HomeController()
		{
			_products = ProductRepository.GetProducts();
		}
		public IActionResult Index()
		{
			var model = new ShopsIndexVM()
			{
				Products = _products
			};
			return View(model);
		}
	}
}