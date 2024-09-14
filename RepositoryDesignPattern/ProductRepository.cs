namespace RepositoryDesignPattern;

public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new List<Product>();

    public void AddProduct(Product product)
    {
        _products.Add(product);

    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _products;
    }

    public Product GetProductById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }

    public void DeleteProduct(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            _products.Remove(product);
        }
    }
}