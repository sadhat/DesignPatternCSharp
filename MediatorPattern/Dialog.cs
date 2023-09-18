namespace MediatorPattern
{
    public class Dialog : IMediator
    {
        private readonly TextBox userTextBox = new();
        private readonly TextBox passTextBox = new();
        private readonly LoginButton button = new();
        public void Login()
        {
            string? userName = userTextBox?.Text;
            string? password = passTextBox?.Text;

            // validate username and password
            // logs in the user or pops error message

            Console.WriteLine("Login with mediator...");
        }
    }
}