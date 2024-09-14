//Repository deseni, veri erişim katmanını iş mantığından ayırmak için kullanılır.
//Veri tabanı işlemlerini bir katmanda soyutlayarak, iş mantığı sınıflarını
//doğrudan veritabanı ile etkileşime sokmak yerine repository aracılığıyla veri işlemlerini gerçekleştiririz.
//Bu desen, kodun test edilebilirliğini ve sürdürülebilirliğini artırır.

using RepositoryDesignPattern;

IProductRepository productRepository = new ProductRepository();

// Yeni ürünler ekleyelim
productRepository.AddProduct(new Product { Id = 1, Name = "Laptop", Price = 1500 });
productRepository.AddProduct(new Product { Id = 2, Name = "Telefon", Price = 800 });


// Tüm ürünleri listeleyelim
var products = productRepository.GetAllProducts();
foreach (var product in products)
{
    Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
}

// ID'ye göre bir ürün bulalım
var singleProduct = productRepository.GetProductById(1);
Console.WriteLine($"ID: {singleProduct.Id}, Name: {singleProduct.Name}, Price: {singleProduct.Price}");

// Ürün silelim
productRepository.DeleteProduct(1);
Console.WriteLine("Ürün silindi!");

// Silindikten sonra tüm ürünleri listeleyelim
products = productRepository.GetAllProducts();
foreach (var product in products)
{
    Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
}


//Repository Pattern'in Avantajları:
//Soyutlama: İş mantığı veri tabanına doğrudan bağımlı değildir. Tüm veri işlemleri repository aracılığıyla yapılır.
//Test Edilebilirlik: Repository deseni sayesinde veri erişim katmanını kolayca mocklayarak test edebilirsiniz.
//Sürdürülebilirlik: Veri kaynağını değiştirmek istediğinizde repository’yi güncellemek yeterli olacaktır, iş mantığını değiştirmeye gerek kalmaz.
//Dezavantajları:
//Ekstra Katman: Küçük projelerde bu ek katman bazen gereksiz karmaşıklık yaratabilir.
//Veri Modeli Bağımlılığı: Veri modeliniz sürekli değişiyorsa repository’deki metotlar da sık sık değişmek zorunda kalabilir.