namespace Application.Abstractions.Messaging
{
    public interface ICommand: IBaseCommand
    {
    }

    public interface ICommand<IResponse> : IBaseCommand
    {

    }

    public interface IBaseCommand
    {

    }
}
