namespace CqrsDesignPattern;

public class CreateOrderCommandHandler
{
    private readonly List<Order> _orders;

    public CreateOrderCommandHandler(List<Order> orders)
    {
        _orders = orders;
    }

    public void Handle(CreateOrderCommand command)
    {
        var order = new Order
        {
            Id = _orders.Count + 1,
            ProductName = command.ProductName,
            Quantity = command.Quantity,
            Price = command.Price
        };
        _orders.Add(order);
        Console.WriteLine($"Order for {command.ProductName} created successfully.");
    }
}
