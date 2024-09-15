namespace DecaratorDesignPattern;

public class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple Coffee";
    }

    public double GetCost()
    {
        return 5.0; // Temel kahve maliyeti
    }
}
