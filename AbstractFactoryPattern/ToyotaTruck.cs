namespace AbstractFactoryPattern;

public class ToyotaTruck : ITruck
{
    public void LoadCargo()
    {
        Console.WriteLine("Loading cargo in a Toyota truck!");
    }
}
