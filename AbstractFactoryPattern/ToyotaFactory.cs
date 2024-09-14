namespace AbstractFactoryPattern;

public class ToyotaFactory : IVehicleFactory
{
    public ICar CreateCar()
    {
        return new ToyotaCar();
    }

    public ITruck CreateTruck()
    {
        return new ToyotaTruck();
    }
}
