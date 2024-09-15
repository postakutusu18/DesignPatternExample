//Proxy Pattern, bir nesnenin başka bir nesneye
//erişimini kontrol etmek için kullanılan bir yapısal tasarım desenidir.
//Proxy, gerçek nesnenin işlevselliğini kısıtlayabilir veya genişletebilir.
//Proxy Pattern'de, gerçek nesneye erişim yerine proxy (vekil) nesneye erişilir.
//Bu desen, özellikle nesnenin kaynak kullanımı veya erişim kontrolü gerektirdiğinde kullanışlıdır.

// Gerçek resmi hemen yüklemek yerine proxy kullanıyoruz
using ProxyPattern;

IImage image = new ImageProxy("myPhoto.jpg");

// Resmi ilk defa görüntülediğimizde yükleme gerçekleşiyor
image.Display();

// İkinci kez görüntülediğimizde yükleme yapılmıyor
image.Display();