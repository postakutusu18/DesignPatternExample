namespace AdapterPattern;

public class CharacterAdapter : IAttack
{
    private readonly ExistingCharacter _existingCharacter;

    public CharacterAdapter(ExistingCharacter existingCharacter)
    {
        _existingCharacter = existingCharacter;
    }

    public void Attack()
    {
        // Burada adaptee sınıfının metodunu çağırıyoruz
        _existingCharacter.PerformAction();
    }
}
