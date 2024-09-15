namespace Mediator;

public class ChatRoom : IMediator
{
    private List<Colleague> _colleagues = new List<Colleague>();

    public void Register(Colleague colleague)
    {
        _colleagues.Add(colleague);
        colleague.SetMediator(this);
    }

    public void SendMessage(string message, Colleague sender)
    {
        foreach (var colleague in _colleagues)
        {
            if (colleague != sender)
            {
                colleague.ReceiveMessage(message);
            }
        }
    }
}