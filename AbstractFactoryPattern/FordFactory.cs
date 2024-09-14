namespace AbstractFactoryPattern;

public class FordFactory : IVehicleFactory
{
    public ICar CreateCar()
    {
        return new FordCar();
    }

    public ITruck CreateTruck()
    {
        return new FordTruck();
    }
}
