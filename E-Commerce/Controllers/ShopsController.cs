using E_Commerce.Data;
using E_Commerce.Entities;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
	public class ShopsController : Controller
	{
		List<Product> _products;
		public ShopsController()
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

		public IActionResult Details(int id)
		{
			var products = _products;

			if (products is null) return RedirectToAction("Index", "404");

			var model = new ShopsDetailsVM
			{
				Product = products.FirstOrDefault(x => x.Id == id)
			};
			
			return View(model);
		}
	}
}
