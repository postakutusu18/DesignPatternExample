using SingletonDesignPattern;

#region Singleton Design Pattern
//Singleton deseni, bir sınıfın yalnızca bir örneğinin oluşturulmasını garanti altına almak için kullanılır.
//Bu desen, global erişime izin verirken bir sınıfın yalnızca bir kez oluşturulmasını sağlar.
//Konfigürasyon Ayarlarının bir yerde tutulması
//Log işlemlerinin tek bir sınıf üzerinden yapılması
//veritabanı bağlantılarının merkezi bir yerde yönetilmesi
//global erişim imkanı sağlaması
//çoklu thread kullanımında dikkatli olmak gerekir.
Logger logger  = Logger.Instance;
logger.Log("First Log");

Logger anotherLogger = Logger.Instance;
anotherLogger.Log("Second Log");
// İki logger nesnesi de aynı instance'dır.
Console.WriteLine(Object.ReferenceEquals(logger, anotherLogger)); // True dönecektir
#endregion
