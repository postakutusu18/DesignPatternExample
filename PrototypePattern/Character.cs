namespace PrototypePattern;

public class Character : ICharacterPrototype
{
    public string Name { get; set; }
    public int Health { get; set; }
    public string Weapon { get; set; }

    public Character(string name, int health, string weapon)
    {
        Name = name;
        Health = health;
        Weapon = weapon;
    }

    public ICharacterPrototype Clone()
    {
        // Bu yöntem nesnenin yüzeysel kopyasını oluşturur.
        return (ICharacterPrototype)this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Character: {Name}, Health: {Health}, Weapon: {Weapon}";
    }
}
