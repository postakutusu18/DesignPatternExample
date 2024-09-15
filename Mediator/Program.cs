//Mediator Pattern, bir grup nesne arasında iletişimi merkezi bir arabulucu nesne aracılığıyla yönetir.
//Bu, nesnelerin birbirleriyle doğrudan iletişim kurmalarını engelleyerek,
//arabulucu aracılığıyla iletişim kurmalarını sağlar.
//Böylece nesneler arasındaki bağımlılıklar azalır ve sistem daha esnek hale gelir.

using Mediator;

ChatRoom chatRoom = new ChatRoom();

User user1 = new User("Alice");
User user2 = new User("Bob");
User user3 = new User("Charlie");

chatRoom.Register(user1);
chatRoom.Register(user2);
chatRoom.Register(user3);

user1.SendMessage("Hello everyone!");
user2.SendMessage("Hi Alice!");