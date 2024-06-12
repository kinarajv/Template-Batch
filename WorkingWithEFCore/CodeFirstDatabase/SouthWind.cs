using Microsoft.EntityFrameworkCore;

namespace CodeFirstDatabase;

public class SouthWind : DbContext
{
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=mydatabase;Username=testadmin;Password=postgres");
	}
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Category>(category =>
		{
			category.HasKey(c => c.CategoryId);
			category.Property(c => c.CategoryId).ValueGeneratedOnAdd();
			category.Property(c => c.CategoryName).IsRequired(true).HasMaxLength(20);
			category.Property(c => c.Description).IsRequired(false).HasMaxLength(50);
			category.HasMany(c => c.Products).WithOne(p => p.Category);
		});
		modelBuilder.Entity<Product>(product =>
		{
			product.HasKey(c => c.ProductId);
			product.Property(c => c.ProductName).IsRequired(true).HasMaxLength(20);
			product.Property(c => c.Description).IsRequired(false).HasMaxLength(50);
		});
		modelBuilder.Entity<Category>().HasData(
			new Category() 
			{
				CategoryId = 1,
				CategoryName = "Electronic",
				Description = "Bebas"
			},
			new Category() 
			{
				CategoryId = 2,
				CategoryName = "Seafood",
				Description = "Bebas"
			}
		);
		// modelBuilder.Entity<Product>().HasData(
		// 	new Product() 
		// 	{
		// 		ProductId = 1,
		// 		ProductName = "Laptop",
		// 		CategoryId = 1,
		// 		Description = "Bebas"
		// 	},
		// 	new Product() 
		// 	{
		// 		ProductId = 2,
		// 		ProductName = "Shrimp",
		// 		CategoryId = 2,
		// 		Description = "Bebas"
		// 	}
		// );
	}
}
