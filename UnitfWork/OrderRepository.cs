namespace UnitfWork;

public class OrderRepository : IOrderRepository
{
    private readonly List<Order> _orders = new List<Order>();

    public IEnumerable<Order> GetAllOrders()
    {
        return _orders;
    }

    public void AddOrder(Order order)
    {
        _orders.Add(order);
    }
}
