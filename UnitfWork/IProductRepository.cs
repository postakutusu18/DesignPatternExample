namespace UnitfWork;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
    void AddProduct(Product product);
}
