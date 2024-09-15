//Strategy Pattern, belirli bir algoritmayı, işlevi veya yöntemi
//farklı şekillerde uygulayarak birbirinin yerine kullanılabilir hale getiren
//bir davranışsal tasarım desenidir.
//Bu desende, bir sınıfın davranışı çalışma zamanında değiştirilebilir ve
//bu davranışlar strateji nesneleri ile temsil edilir.

//Kullanım Alanları:
//Bir nesnenin davranışı çalışma zamanında farklı stratejilere göre değiştirildiğinde.
//Aynı işlevi gerçekleştiren, fakat farklı algoritmalar kullanan nesneler olduğunda.
//Yazılımın esnek ve genişletilebilir olması gerektiğinde, böylece yeni stratejiler kolayca eklenebilir.

using StrategyPattern;

PaymentContext paymentContext = new PaymentContext();

// Kredi kartı ile ödeme
paymentContext.SetPaymentStrategy(new CreditCardPayment());
paymentContext.MakePayment(250.75m);

// PayPal ile ödeme
paymentContext.SetPaymentStrategy(new PayPalPayment());
paymentContext.MakePayment(120.50m);

// Havale ile ödeme
paymentContext.SetPaymentStrategy(new BankTransferPayment());
paymentContext.MakePayment(300.00m);