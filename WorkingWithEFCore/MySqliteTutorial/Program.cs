using Microsoft.EntityFrameworkCore;
using MySqliteTutorial;

class Program
{
	static async Task Main()
	{
		//For Dispose purpose
		//Open connection to the Database
		using (Northwind db = new())
		{
			
			//Read
			//Check Database connection is valid or not
			Console.WriteLine(db.Database.CanConnect());
			//For view all Category
			//Include for Eager Loading
			List<Category> categories = db.Categories
			.Include(c => c.Products)
			.ToList();
			foreach (var c in categories)
			{
				Console.WriteLine($"{c.CategoryId} : {c.CategoryName}");
				Console.WriteLine(c.Products.Count());
				foreach (var p in c.Products)
				{
					Console.WriteLine($"	{p.ProductId} : {p.ProductName}");
				}
			}
			//For view Product that price is more than 20
			var products = db.Products
			.Include(p => p.Supplier)
			.Where(p => p.Cost > 20);
			
			foreach (var p in products)
			{
				Console.WriteLine(p.Supplier.SupplierId);
				Console.WriteLine($"\t{p.ProductId} : {p.ProductName} cost : {p.Cost} stock : {p.Stock}");
			}

			//Where => SELECT * FROM "Product" WHERE "ProductId"==x
			//Contains
			//Find
			//FirstOrDefault
			//Select List<string> categoryNames = db.Categories.Select(c => c.CategoryName).ToList();
			//OrderBy
			//Distinct List<string> categoryNames = db.Categories.Select(c => c.CategoryName).Distinct();

			//CUD : Create Update Delete
			//Wajib ditutup dengan SaveChanges()
			Category category = new Category()
			{
				CategoryName = "Electronic",
				Description = "Ini Electronic"
			};
			await db.Categories.AddAsync(category);
			await db.SaveChangesAsync();
			
			//Update
			Category? result = db.Categories.Find(9);
			if(result is not null) 
			{
				result.CategoryName = "Mobil";
				result.Description = "Ini mobil";
			}
			await db.SaveChangesAsync();

			Category? result2 = await db.Categories
			.FirstOrDefaultAsync(c => c.CategoryName
			.Contains("Mobil")); 
			
			if(result2 is not null) 
			{
				result2.CategoryName = "Motor";
				result2.Description = "Ini Motor";
			}
			await db.SaveChangesAsync();

			//Delete
			IQueryable<Category> deletedCategory = db.Categories
			.Where(c => c.CategoryName == "Electronic");
			
			db.Categories.RemoveRange(deletedCategory);
			await db.SaveChangesAsync();
		}
	}
}
