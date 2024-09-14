namespace AbstractFactoryPattern;

public class FordTruck : ITruck
{
    public void LoadCargo()
    {
        Console.WriteLine("Loading cargo in a Ford truck!");
    }
}
