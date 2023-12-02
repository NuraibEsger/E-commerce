using E_Commerce.Data;
using E_Commerce.Entities;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace E_Commerce.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index(int id)
		{
			List<BasketItem> BasketItemLists;
			BasketItem? _newBasketItem = null;

			var products = ProductRepository.GetProducts().FirstOrDefault(x=>x.Id == id);

			if (products is null) return RedirectToAction("Index", "404");

			var model = new CartIndexVM
			{
				Product = products
			};

			var newBasketItem = new BasketItem
			{
				Id = id,
				Count = 1,
			};

			Request.Cookies.TryGetValue("basket", out string? existingBasket);

			if (!string.IsNullOrWhiteSpace(existingBasket))
			{
				BasketItemLists = JsonSerializer.Deserialize<List<BasketItem>>(existingBasket)!;
				_newBasketItem = BasketItemLists.FirstOrDefault(x => x.	Id == products.Id);
			}
			else { BasketItemLists = new(); }

			if(_newBasketItem is null)
			{
				_newBasketItem = new BasketItem()
				{
					Id = products.Id,
					Count = 1,
				};
				BasketItemLists.Add(_newBasketItem);
			}
			else
			{
				_newBasketItem.Count ++;
			}

			BasketItemLists.Add(_newBasketItem);

			Response.Cookies.Append("basket", JsonSerializer.Serialize(BasketItemLists));

			return View(model);
		}
	}
}
