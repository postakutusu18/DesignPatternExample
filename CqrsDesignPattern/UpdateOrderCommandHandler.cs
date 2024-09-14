namespace CqrsDesignPattern;

public class UpdateOrderCommandHandler
{
    private readonly List<Order> _orders;

    public UpdateOrderCommandHandler(List<Order> orders)
    {
        _orders = orders;
    }

    public void Handle(UpdateOrderCommand command)
    {
        var order = _orders.FirstOrDefault(o => o.Id == command.Id);
        if (order != null)
        {
            order.ProductName = command.ProductName;
            order.Quantity = command.Quantity;
            order.Price = command.Price;
            Console.WriteLine($"Order {command.Id} updated successfully.");
        }
    }
}
