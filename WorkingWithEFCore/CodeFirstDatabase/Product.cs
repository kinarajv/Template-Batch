using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase;

public class Product
{
	public int ProductId { get; set; }
	public string ProductName { get; set; } = null!;
	public string? Description { get; set; }
	public int CategoryId { get; set; }
	public Category Category { get; set; } = null!;
	public int UnitPrice { get; set; }
	public short UnitInStock { get; set; }
}
