using Command.Commands;
using System.Collections.Generic;
using System.Linq;

namespace Command
{
    public class CommandParser
    {
        readonly IEnumerable<ICommandFactory> availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            this.availableCommands = availableCommands;
        }

        internal ICommand ParseCommand(string[] args)
        {
            var requestedCommandName = args[0];

            var command = FindRequestedCommand(requestedCommandName);

            return command.MakeCommand(args);
        }

        private ICommandFactory FindRequestedCommand(string commandName)
        {
            return availableCommands.FirstOrDefault(cmd => cmd.CommandName.Equals(commandName));
        }
    }
}
