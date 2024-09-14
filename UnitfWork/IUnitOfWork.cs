namespace UnitfWork;

public interface IUnitOfWork : IDisposable
{
    IProductRepository Products { get; }
    IOrderRepository Orders { get; }
    void Complete();  // İşlemleri kaydetmek için kullanılır
}
