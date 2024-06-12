using System.ComponentModel.DataAnnotations;

namespace MySqliteTutorial;

public class Supplier
{
	[Key]
	public int SupplierId { get; set; }
	[Required]
	public string CompanyName { get; set; } = null!;
	public ICollection<Product> Products { get; set; }
	public Supplier() 
	{
		Products = new HashSet<Product>();
	}
}
