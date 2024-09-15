namespace BuilderPattern;

public class CarDirector
{
    private readonly ICarBuilder _builder;

    public CarDirector(ICarBuilder builder)
    {
        _builder = builder;
    }

    public void BuildSportsCar()
    {
        _builder.SetEngine("V8 Engine");
        _builder.SetWheels(4);
        _builder.SetColor("Red");
    }

    public void BuildSUV()
    {
        _builder.SetEngine("V6 Engine");
        _builder.SetWheels(4);
        _builder.SetColor("Black");
    }
}
