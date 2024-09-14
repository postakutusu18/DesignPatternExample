namespace ObserverPattern;

public class StatisticsDisplay : IObserver
{
    private List<float> temperatureReadings = new List<float>();

    public void Update(float temperature, float humidity, float pressure)
    {
        temperatureReadings.Add(temperature);
        Console.WriteLine($"Avg/Max/Min temperature = {temperatureReadings.Average()}/{temperatureReadings.Max()}/{temperatureReadings.Min()}");
    }
}
