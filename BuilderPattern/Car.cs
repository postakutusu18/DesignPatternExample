namespace BuilderPattern;

public class Car
{
    public string Engine { get; set; }
    public int Wheels { get; set; }
    public string Color { get; set; }

    public override string ToString()
    {
        return $"Car with Engine: {Engine}, Wheels: {Wheels}, Color: {Color}";
    }
}
