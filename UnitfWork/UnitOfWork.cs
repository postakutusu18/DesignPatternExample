namespace UnitfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ProductRepository _productRepository = new ProductRepository();
    private readonly OrderRepository _orderRepository = new OrderRepository();

    public IProductRepository Products => _productRepository;
    public IOrderRepository Orders => _orderRepository;

    // İşlemleri tamamlamak için kullanılır (Veritabanı bağlantısı varsa SaveChanges() burada yapılır)
    public void Complete()
    {
        // Gerçek projelerde buraya transaction commit işlemi yazılır
        Console.WriteLine("All changes saved successfully.");
    }

    public void Dispose()
    {
        // Dispose işlemleri (Veritabanı bağlantısını burada kapatabilirsiniz)
    }
}
