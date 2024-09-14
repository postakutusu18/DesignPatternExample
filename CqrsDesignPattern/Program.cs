using CqrsDesignPattern;


//CQRS, Command Query Responsibility Segregation yani Komut ve Sorgu Sorumluluğu Ayrımı anlamına gelir.
//Bu desen, veri yazma (komut) ve veri okuma (sorgu) işlemlerinin ayrı ayrı yönetildiği bir mimari yaklaşımdır.
//Amaç, yazma ve okuma işlemlerinin birbirinden bağımsız hale getirilerek optimize edilmesi
//ve sistemin performansının artırılmasıdır.

//Kullanım Senaryoları:
//Büyük ölçekli uygulamalarda veri okuma ve yazma işlemleri arasında farklı performans gereksinimleri varsa.
//Karmaşık domain modellerinde, veri yazma ve okuma işlemlerini basitleştirmek için.
//Mikroservis mimarilerinde, okuma ve yazma işlemlerini farklı veri kaynaklarına yönlendirmek için.
//CQRS Mimarisi
//CQRS, sistemi iki ana bölümde ele alır:
//Komutlar(Commands): Veri üzerinde değişiklik yapan işlemler (Insert, Update, Delete).
//Komutlar her zaman bir yan etkiye neden olur.
//Sorgular (Queries): Verileri okumak için kullanılan işlemler.
//Sorgular veri üzerinde bir değişiklik yapmaz, sadece veri okur.



OrderService orderService = new OrderService();

// Yeni sipariş oluştur
var createOrderCommand = new CreateOrderCommand
{
    ProductName = "Laptop",
    Quantity = 1,
    Price = 1500
};
orderService.CreateOrder(createOrderCommand);

// Tüm siparişleri getir
var orders = orderService.GetAllOrders();
foreach (var order in orders)
{
    Console.WriteLine($"Order: {order.ProductName}, Quantity: {order.Quantity}, Price: {order.Price}");
}

// Bir siparişi güncelle
var updateOrderCommand = new UpdateOrderCommand
{
    Id = 1,
    ProductName = "Gaming Laptop",
    Quantity = 2,
    Price = 2000
};
orderService.UpdateOrder(updateOrderCommand);

// Siparişi ID ile getir
var orderById = orderService.GetOrderById(new GetOrderByIdQuery { Id = 1 });
Console.WriteLine($"Updated Order: {orderById.ProductName}, Quantity: {orderById.Quantity}, Price: {orderById.Price}");
