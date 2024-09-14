using AbstractFactoryPattern;

//Abstract Factory Pattern, birbirleriyle ilişkili nesnelerden oluşan aileleri
//üretmek için kullanılan bir tasarım desenidir. Bu desende,
//nesnelerin birbiriyle nasıl ilişkili olduğunu bilen soyut fabrikalar kullanılır.

//Kullanım Senaryoları:
//Birbiriyle ilişkili ya da bağımlı nesneleri birlikte üretmek gerekiyorsa.
//Farklı nesne ailesi varyasyonları varsa ve bu varyasyonları merkezi bir fabrikadan yönetmek gerekiyorsa.


IVehicleFactory toyotaFactory = new ToyotaFactory();
ICar toyotaCar = toyotaFactory.CreateCar();
ITruck toyotaTruck = toyotaFactory.CreateTruck();

toyotaCar.Drive();
toyotaTruck.LoadCargo();

IVehicleFactory fordFactory = new FordFactory();
ICar fordCar = fordFactory.CreateCar();
ITruck fordTruck = fordFactory.CreateTruck();

fordCar.Drive();
fordTruck.LoadCargo();