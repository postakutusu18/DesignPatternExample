namespace AbstractFactoryPattern;

public class FordCar : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving a Ford car!");
    }
}
