namespace MediatorPattern
{
    public class LoginButton: IComponent
    {
        private IMediator? mediator;

        public void OnFireActionPerformed()
        {
            mediator?.Login();
        }

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        
        }
        public string GetName()
        {
            return "LoginButton";
        }
    }

    public class TextBox
    {
        public string? Text { get; set; }
    }
}