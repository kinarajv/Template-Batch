using Microsoft.EntityFrameworkCore;
using EFCore;
namespace EFDatabase;

public class Northwind : DbContext
{
	public DbSet<Category> Categories {get;set;}
	public DbSet<Product> Products {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
		optionsBuilder.UseSqlite("FileName=./Northwind.db");
    }
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Category>(cat => 
		{
			cat.HasKey(e => e.CategoryId);
			cat.Property(e => e.CategoryName).IsRequired().HasMaxLength(40);
			cat.Property(e => e.Description).HasColumnType("NTEXT");
			cat.HasMany(cat => cat.Products).WithOne(p => p.Category);
		});
		modelBuilder.Entity<Product>(pro =>
		{
			pro.Property(p => p.ProductName).IsRequired().HasMaxLength(40);
			pro.Property(p => p.Cost).HasColumnType("money").HasColumnName("UnitPrice");
			// pro.HasOne(p => p.Category).WithMany(cat => cat.Products);
		});

	}
}