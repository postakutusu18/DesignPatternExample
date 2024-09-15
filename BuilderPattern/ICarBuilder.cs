namespace BuilderPattern;

public interface ICarBuilder
{
    void SetEngine(string engine);
    void SetWheels(int wheels);
    void SetColor(string color);
    Car GetCar();
}
