using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace EFCore
{
	public class Category
	{
		public int CategoryId { get; set; } //Primary Key
		public string CategoryName { get; set; }
		[Column(TypeName = "NTEXT")]
		public string? Description { get; set; }
		public ICollection<Product> Products { get; set; }
		public Category() 
		{
			Products = new HashSet<Product>();
		}
	}
}