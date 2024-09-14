namespace AbstractFactoryPattern;

public interface IVehicleFactory
{
    ICar CreateCar();
    ITruck CreateTruck();
}
