namespace AbstractFactoryPattern;

public class ToyotaCar : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving a Toyota car!");
    }
}
