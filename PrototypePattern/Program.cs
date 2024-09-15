

//Prototype Pattern, yeni bir nesne oluşturmak yerine mevcut bir nesneyi kopyalayarak (clone) yeni bir nesne yaratmayı sağlar.
//Bu, özellikle nesnelerin oluşturulmasının maliyetli olduğu durumlarda performans kazancı sağlar.
//Bu desende, bir nesnenin yeni bir örneğini oluşturmak yerine, var olan bir nesne klonlanır.
// Bir temel karakter yaratıyoruz
using PrototypePattern;

Character warrior = new Character("Warrior", 100, "Sword");
Console.WriteLine(warrior.ToString());

// Bu karakteri klonlayarak yeni karakterler oluşturuyoruz
Character clonedWarrior = (Character)warrior.Clone();
clonedWarrior.Name = "Cloned Warrior";
Console.WriteLine(clonedWarrior.ToString());

// Orijinal karakter değişmeden kalır
Console.WriteLine(warrior.ToString());

// Başka bir karakter daha klonlayalım
Character mage = new Character("Mage", 80, "Staff");
Character clonedMage = (Character)mage.Clone();
clonedMage.Name = "Cloned Mage";
Console.WriteLine(clonedMage.ToString());

//Avantajlar:
//Yeni bir nesne oluşturmak yerine mevcut bir nesneyi kopyalayarak zaman ve performans kazancı sağlar.
//Karmaşık nesnelerin oluşturulmasını basitleştirir.
//Dezavantajlar:
//Yüzeysel kopyalama bazen istenmeyen sonuçlar doğurabilir, özellikle iç içe geçmiş nesneler varsa.
//Her nesneye uygun klonlama yöntemi yazmanız gerekebilir.