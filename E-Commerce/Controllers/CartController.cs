﻿using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
