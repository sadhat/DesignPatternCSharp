public interface INotifier
{
    void Send(string message);
    string UserName { get; }
}

public class Notifier : INotifier
{
    public Notifier(string userName)
    {
        UserName = userName;
    }

    public string UserName { get; }

    public void Send(string message)
    {
        Console.WriteLine($"Sending {message} by Mail");
    }
}