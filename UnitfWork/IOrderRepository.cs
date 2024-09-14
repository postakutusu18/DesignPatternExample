namespace UnitfWork;

public interface IOrderRepository
{
    IEnumerable<Order> GetAllOrders();
    void AddOrder(Order order);
}