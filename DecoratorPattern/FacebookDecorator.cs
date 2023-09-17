public class FacebookDecorator : BaseNotifierDecorator
{
    public FacebookDecorator(INotifier wrapped) : base(wrapped)
    {
    }

    public override void Send(string message)
    {
        Console.WriteLine($"Sending {message} by Facebook");
    }
}