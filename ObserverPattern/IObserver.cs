namespace ObserverPattern;

public interface IObserver
{
    void Update(float temperature, float humidity, float pressure);
}


public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}
