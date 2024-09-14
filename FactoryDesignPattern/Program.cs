using FactoryDesignPattern;


//Factory(Fabrika) deseni, nesne oluşturma sürecini bir yere toplamak ve yönetmek için kullanılan bir desen.
//Bu desen, hangi sınıfın örneğinin oluşturulacağını belirleyen
//bir fabrika (factory) sınıfı kullanarak nesne oluşturma işlemini soyutlar.

//Kullanım Senaryoları
//Uygulamanızda birden fazla türde nesne oluşturuyorsanız.
//Nesne oluşturma süreci karmaşık hale geliyorsa.
//Nesneler arasında hangi tipin oluşturulacağını merkezi bir yerden kontrol etmek istiyorsanız.

AnimalFactory animalFactory = new AnimalFactory();

IAnimal dog = animalFactory.CreateAnimal("Dog");
dog.Speak();

IAnimal cat = animalFactory.CreateAnimal("Cat");
cat.Speak();


//Factory Pattern'in Avantajları:
//Nesne oluşturmayı soyutlar: Factory sınıfı, nesne oluşturma detaylarını gizler ve karmaşık nesne yaratma işlemleriyle ilgilenir.
//Genişletilebilirlik: Yeni türler eklemek kolaydır. Örneğin, yeni bir hayvan sınıfı eklemek için mevcut kodu değiştirmek
//yerine sadece yeni sınıfı ve fabrika metodunda küçük bir güncelleme yapmanız yeterlidir.
//Dezavantajları:
//Karmaşıklık: Bazı küçük projelerde bu ekstra soyutlama gereksiz karmaşıklık yaratabilir.
//Bakım Maliyeti: Fabrika sınıfında çok fazla tür varsa, zamanla bu sınıfın bakımı zorlaşabilir.