namespace Application.Abstractions.Messaging
{
    public interface ICommendHandler<in ICommand>
    {
        Task Handle<TCommand command, CancellationToken cancellationToken>;
    }
}
