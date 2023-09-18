namespace MediatorPattern
{
    public interface IComponent
    {
         void SetMediator(IMediator mediator);
         string GetName();
    }
}