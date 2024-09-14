namespace SingletonDesignPattern;

public class Logger
{
    // 1. Statik bir örnek oluştur.
    private static Logger _instance;

    // 2. Erişim kilidi (thread safety için)
    private static readonly object _lock = new object();
    
    // 3. Constructor'ı private yaparak dışarıdan nesne oluşturmayı engelle.
    private Logger()
    {

    }
    // 4. Singleton instance'ı almak için bir metod tanımla.
    public static Logger Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }
    }

    // 5. Log yazma metodu.
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
