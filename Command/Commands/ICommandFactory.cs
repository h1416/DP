namespace Command.Commands
{
    public interface ICommandFactory
    {
        string CommandName { get; }
        string Desciption { get; }

        ICommand MakeCommand(string[] arguments);
    }
}
