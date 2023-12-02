using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Views.Shared.Components.Testimonail
{
	public class TestimonailViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
