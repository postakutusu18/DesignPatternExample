using UnitfWork;

//Unit of Work deseni, bir işlem grubunu tek bir birim olarak yönetir.
//Birden fazla veritabanı işlemi yapıldığında, hepsi tek bir işlem (transaction) içinde gerçekleştirilir.
//Bu, işlemlerin toplu bir şekilde başarılı olup olmadığını kontrol etmemizi sağlar ve
//bir hata durumunda tüm işlemleri geri almamıza (rollback) olanak tanır.


using (var unitOfWork = new UnitOfWork())
{
    // Ürün ekleyelim
    unitOfWork.Products.AddProduct(new Product { Id = 1, Name = "Laptop", Price = 1500 });

    // Sipariş ekleyelim
    unitOfWork.Orders.AddOrder(new Order { Id = 1, ProductId = 1, Quantity = 2 });

    // İşlemleri kaydet
    unitOfWork.Complete();

    // Eklenen ürünleri ve siparişleri listele
    var products = unitOfWork.Products.GetAllProducts();
    foreach (var product in products)
    {
        Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
    }

    var orders = unitOfWork.Orders.GetAllOrders();
    foreach (var order in orders)
    {
        Console.WriteLine($"Order for ProductId: {order.ProductId}, Quantity: {order.Quantity}");
    }
}

//Unit of Work Pattern'in Avantajları:
//Transaction Yönetimi: Birden fazla işlemi tek bir transaction içinde yönetir, böylece işlem bütünlüğü sağlanır.
//Merkezi Kontrol: Tüm repository'leri tek bir yerden yönetir ve işlemleri tek bir yerde kaydeder.
//Kod Tekrarını Azaltma: Transaction başlatma ve işlemleri tamamlama gibi işlemleri merkezi bir yere toplar.
//Dezavantajları:
//Karmaşıklık: Küçük projelerde bu ek yapı gereksiz karmaşıklık yaratabilir.
//Repository Bağımlılığı: Repository sayısı arttıkça Unit of Work sınıfı da karmaşık hale gelebilir.