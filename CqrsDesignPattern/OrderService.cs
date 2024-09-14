namespace CqrsDesignPattern;

public class OrderService
{
    private readonly List<Order> _orders = new List<Order>();

    public void CreateOrder(CreateOrderCommand command)
    {
        var handler = new CreateOrderCommandHandler(_orders);
        handler.Handle(command);
    }

    public void UpdateOrder(UpdateOrderCommand command)
    {
        var handler = new UpdateOrderCommandHandler(_orders);
        handler.Handle(command);
    }

    public Order GetOrderById(GetOrderByIdQuery query)
    {
        var handler = new GetOrderByIdQueryHandler(_orders);
        return handler.Handle(query);
    }

    public IEnumerable<Order> GetAllOrders()
    {
        var handler = new GetAllOrdersQueryHandler(_orders);
        return handler.Handle(new GetAllOrdersQuery());
    }
}
