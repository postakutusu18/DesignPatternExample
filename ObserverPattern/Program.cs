using ObserverPattern;



//Observer(Gözlemci) deseni, bir nesnede meydana gelen değişiklikleri diğer nesnelere bildirmek için kullanılır.
//Bu desende, bir nesne (subject) üzerinde değişiklikler olduğunda,
//bu değişiklikler kendisine bağlı (aboneliği olan) nesnelere (observers) bildirilir.
//Böylece, subject'in durumundaki herhangi bir değişiklikten tüm gözlemciler haberdar olur.

//Kullanım Senaryoları:
//Bir nesnedeki değişikliklerin, birçok nesneye bildirilmesi gerektiğinde.
//Bir olay olduğunda, birden fazla sınıfın bu olaydan haberdar olması gerekiyorsa.
//Kullanıcı arayüzünde bir bileşen değiştiğinde, diğer bileşenleri otomatik olarak güncellemek istiyorsanız.


WeatherStation weatherStation = new WeatherStation();

// Gözlemcileri (ekranları) kaydediyoruz
CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
StatisticsDisplay statisticsDisplay = new StatisticsDisplay();

weatherStation.RegisterObserver(currentDisplay);
weatherStation.RegisterObserver(statisticsDisplay);

// Hava durumu değişikliklerini set edelim
weatherStation.SetMeasurements(25, 65, 1013);
weatherStation.SetMeasurements(28, 70, 1012);
weatherStation.SetMeasurements(26, 60, 1011);