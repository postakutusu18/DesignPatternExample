//Adapter Pattern, bir sınıfın arayüzünü, istemcinin beklediği farklı bir arayüze dönüştürerek,
//farklı sistemlerin birlikte çalışmasını sağlar.
//Bu tasarım deseni, iki uyumsuz sınıfı bir araya getirmeye yarar.
//Yani, istemcinin mevcut olan ama farklı bir arayüze sahip sınıfı
//kullanabilmesi için bir "adaptör" (uyarlayıcı) oluşturur.

//Kullanım Alanları:
//Bir nesnenin mevcut arayüzünün, farklı bir arayüze sahip olması gerektiğinde.
//Var olan bir sınıfın, mevcut kodla uyumlu hale getirilmesi gerektiğinde.
//Üçüncü taraf kütüphaneleri ya da eski sistemler ile entegrasyon sağlarken.

// İstemci normal bir saldırı bekliyor
using AdapterPattern;

IAttack attacker = new CharacterAdapter(new ExistingCharacter());
attacker.Attack();  // Adaptör sayesinde eski karakterin metodunu çağırıyor