namespace Mediator;

public class User : Colleague
{
    private string _name;

    public User(string name)
    {
        _name = name;
    }

    public override void ReceiveMessage(string message)
    {
        Console.WriteLine($"{_name} received message: {message}");
    }

    public void SendMessage(string message)
    {
        _mediator.SendMessage(message, this);
    }
}
