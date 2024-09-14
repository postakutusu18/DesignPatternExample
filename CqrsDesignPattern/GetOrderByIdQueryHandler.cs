namespace CqrsDesignPattern;

public class GetOrderByIdQueryHandler
{
    private readonly List<Order> _orders;

    public GetOrderByIdQueryHandler(List<Order> orders)
    {
        _orders = orders;
    }

    public Order Handle(GetOrderByIdQuery query)
    {
        return _orders.FirstOrDefault(o => o.Id == query.Id);
    }
}
