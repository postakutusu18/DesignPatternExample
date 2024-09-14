namespace ObserverPattern;

public class CurrentConditionsDisplay : IObserver
{
    public void Update(float temperature, float humidity, float pressure)
    {
        Console.WriteLine($"Current conditions: {temperature}C degrees and {humidity}% humidity.");
    }
}
