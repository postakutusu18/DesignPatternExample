//Decorator Pattern, bir nesnenin işlevselliğini alt sınıflar oluşturmadan
//dinamik olarak genişletmek için kullanılır.
//Bu desen, bir nesneye yeni işlevler ekler ve bunu, o nesnenin yapısını bozmadan gerçekleştirir.
//Temel olarak, bir nesnenin özelliklerini farklı sınıflar veya objeler aracılığıyla "süsleyerek" genişletiriz.

// Basit kahve
using DecaratorDesignPattern;

ICoffee coffee = new SimpleCoffee();
Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");

// Süt eklenmiş kahve
coffee = new MilkDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");

// Süt ve şeker eklenmiş kahve
coffee = new SugarDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");



//Avantajlar:
//Dinamik olarak nesneleri genişletir.
//Kalıtım yerine kompozisyon kullanır, bu da daha esnek bir yapıya olanak tanır.
//Nesneye yeni işlevsellik eklemek için alt sınıf oluşturmadan dekoratör sınıfları kullanılır.
//Dezavantajlar:
//Çok fazla dekoratör olduğunda, kodun izlenmesi ve yönetimi zor olabilir.
//Gereğinden fazla dekoratör kullanmak, nesnelerin karmaşıklığını artırabilir.