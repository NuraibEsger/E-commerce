using E_Commerce.Entities;

namespace E_Commerce.Data
{
	public class ProductRepository
	{
		public static List<Product> products = new()
		{
			new() { Id = 1, Name = "Strawberry", Price = 85, ImagePath = "products/product-img-1.jpg"},
			new() { Id = 2, Name = "Berry", Price = 70, ImagePath = "products/product-img-2.jpg"},
			new() { Id = 3, Name = "Lemon", Price = 35, ImagePath = "products/product-img-3.jpg"},
			new() { Id = 4, Name = "Avocado", Price = 50, ImagePath = "products/product-img-4.jpg"},
			new() { Id = 5, Name = "Green Apple", Price = 45, ImagePath = "products/product-img-5.jpg"},
			new() { Id = 6, Name = "Strawberry", Price = 80, ImagePath = "products/product-img-6.jpg"},
		};

		public static List<Product> GetProducts() { return products; }
	}
}
