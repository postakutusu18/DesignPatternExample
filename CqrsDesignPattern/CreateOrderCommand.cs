namespace CqrsDesignPattern;

// Commands
public class CreateOrderCommand
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
