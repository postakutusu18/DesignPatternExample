namespace Mediator;

public abstract class Colleague
{
    protected IMediator _mediator;

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }

    public abstract void ReceiveMessage(string message);
}