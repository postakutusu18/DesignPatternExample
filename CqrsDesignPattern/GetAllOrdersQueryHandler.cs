namespace CqrsDesignPattern;

public class GetAllOrdersQueryHandler
{
    private readonly List<Order> _orders;

    public GetAllOrdersQueryHandler(List<Order> orders)
    {
        _orders = orders;
    }

    public IEnumerable<Order> Handle(GetAllOrdersQuery query)
    {
        return _orders;
    }
}
