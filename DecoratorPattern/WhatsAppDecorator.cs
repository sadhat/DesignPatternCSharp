public class WhatsAppDecorator : BaseNotifierDecorator
{
    public WhatsAppDecorator(INotifier wrapped) : base(wrapped)
    {
    }

    public override void Send(string message)
    {
        Console.WriteLine($"Sending {message} by WhatsApp");
    }
}