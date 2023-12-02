using E_Commerce.Entities;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Views.Shared.Components.Shops
{
	public class ProductsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke(Product product)
		{
			return View(product);
		}
	}
}
