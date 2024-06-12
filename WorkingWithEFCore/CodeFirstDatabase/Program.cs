using CodeFirstDatabase;

class Program 
{
	static void Main() 
	{
		using(SouthWind db = new()) 
		{
			db.Categories.Add(new Category()
			{
				CategoryName = "TESTer"
			});
			db.SaveChanges();
		}
	}
}