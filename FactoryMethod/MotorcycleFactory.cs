namespace FactoryMethod;

public class MotorcycleFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Motorcycle();
    }
}
