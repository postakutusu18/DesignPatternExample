//Facade Pattern, karmaşık sistemlere bir basitleştirilmiş arayüz sunar.
//Bir sistemde birden fazla alt sistem ya da sınıf varsa,
//bu sınıfları direkt kullanmak yerine araya bir "cephe" sınıfı koyarak istemcinin
//bu alt sistemlerle etkileşime girmesini kolaylaştırabilirsiniz.
//Facade Pattern, karmaşık bir yapıdaki sistemlerin daha kolay anlaşılmasını ve kullanılmasını sağlar.

//Bir müzik çalma uygulamanız olduğunu düşünün.
//Kullanıcı bir butona bastığında, müzik çalmaya başlamadan önce birçok işlem yapılması gerekir:
//dosya açma, kod çözme, oynatma.
//Kullanıcı bu karmaşık süreçlerle uğraşmamalı, sadece tek bir butonla müziği başlatabilmelidir.
//Facade Pattern burada kullanıcının karmaşık sistemi tek bir arayüzden kontrol etmesini sağlar.

using FacadePattern;
AudioPlayerFacade audioPlayer = new AudioPlayerFacade();
audioPlayer.PlayAudio("song.mp3");