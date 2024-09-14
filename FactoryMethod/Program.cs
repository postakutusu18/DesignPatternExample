
using FactoryMethod;
using System.Runtime.ConstrainedExecution;


//Factory Method Pattern, bir sınıfın nesne üretimini alt sınıflara devrettiği bir tasarım desenidir.
//Bu desende, her alt sınıf kendi türüne göre bir nesne oluşturur.
//Bu sayede, nesne oluşturma işlemi sınıflar arasında çeşitlilik gösterir.

//Kullanım Senaryoları:
//Alt sınıfların, hangi nesne tipini üreteceklerini belirlemesi gerekiyorsa.
//İstemciye farklı türde nesneler sunarken, bu nesnelerin nasıl üretildiği bilgisini gizlemek istiyorsanız.



VehicleFactory carFactory = new CarFactory();
IVehicle car = carFactory.CreateVehicle();
car.Drive();

VehicleFactory truckFactory = new TruckFactory();
IVehicle truck = truckFactory.CreateVehicle();
truck.Drive();

VehicleFactory motorcycleFactory = new MotorcycleFactory();
IVehicle motorcycle = motorcycleFactory.CreateVehicle();
motorcycle.Drive();


//Factory Method Pattern'in Avantajları:
//Esneklik: Yeni araç türleri eklemek için yeni bir fabrika sınıfı oluşturmak yeterlidir.
//Kolay Bakım: Her fabrika sınıfı yalnızca kendi türüne özgü nesne üretimiyle ilgilendiğinden,
//kodun yönetimi ve bakımı kolaydır.
//Dezavantajları:
//Çok Fazla Sınıf: Her nesne türü için yeni bir fabrika sınıfı oluşturmak gerekebilir,
//bu da sınıf sayısının artmasına neden olur.