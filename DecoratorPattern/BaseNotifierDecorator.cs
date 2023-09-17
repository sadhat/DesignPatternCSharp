public abstract class BaseNotifierDecorator : INotifier
{
    private readonly INotifier wrapped;

    protected BaseNotifierDecorator(INotifier wrapped)
    {
        this.wrapped = wrapped;
    }

    public string UserName
    {
        get
        {
            return wrapped.UserName;
        }
    }

    public virtual void Send(string message)
    {
        wrapped.Send(message);
    }
    
}