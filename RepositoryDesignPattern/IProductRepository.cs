namespace RepositoryDesignPattern;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
    Product GetProductById(int id);
    void AddProduct(Product product);
    void DeleteProduct(int id);
}
