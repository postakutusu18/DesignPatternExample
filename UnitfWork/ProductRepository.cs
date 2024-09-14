namespace UnitfWork;

public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new List<Product>();

    public IEnumerable<Product> GetAllProducts()
    {
        return _products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}
