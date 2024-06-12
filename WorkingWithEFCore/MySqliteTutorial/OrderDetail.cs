namespace MySqliteTutorial;

public class OrderDetail
{
	public int OrderId { get; set; }
	public int ProductId { get; set; }
	public Product Product { get; set; } = null!;
	public Order Order { get; set; } = null!;
}
