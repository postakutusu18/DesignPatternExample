using BuilderPattern;


//Builder Design Pattern, karmaşık nesnelerin adım adım oluşturulması gereken durumlarda kullanılır.
//Bu tasarım deseni, nesne oluşturma sürecini basitleştirir ve esnek hale getirir.
//Özellikle birçok parametreye sahip karmaşık nesnelerin inşasında faydalıdır.
//Her aşamada, nesnenin belirli parçaları yapılandırılır ve sonunda tam bir nesne oluşturulur.

//Builder Pattern'ın Temel Yapısı
//Builder: Karmaşık nesneleri adım adım oluşturan arayüz veya soyut sınıf.
//ConcreteBuilder: Builder arayüzünü uygulayan ve belirli nesneleri inşa eden somut sınıf.
//Director: Builder'ı kullanan sınıf, karmaşık nesnenin inşa sürecini kontrol eder.
//Product: Builder tarafından oluşturulan karmaşık nesne.


ICarBuilder builder = new CarBuilder();
CarDirector director = new CarDirector(builder);

// Spor araba inşa et
director.BuildSportsCar();
Car sportsCar = builder.GetCar();
Console.WriteLine(sportsCar.ToString());

// SUV inşa et
director.BuildSUV();
Car suv = builder.GetCar();
Console.WriteLine(suv.ToString());