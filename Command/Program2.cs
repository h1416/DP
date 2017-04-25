using Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program2
    {

        public static void Run(string[] args)
        {
            var availableCommands = GetAvailableCommands();

            if (args.Length == 0)
            {
                PrintUsage(availableCommands);
                return;
            }

            var parser = new CommandParser(availableCommands);
            var command = parser.ParseCommand(args);

            if (command != null)
                command.Execute();
        }
        public static IEnumerable<ICommandFactory> GetAvailableCommands()
        {
            return new ICommand[] { new CreateOrderCommand(), new UpdateQuantityCommand(), new ShipOrderCommand()};
        }


        public static void PrintUsage(IEnumerable<ICommandFactory> availableCommands)
        {
            Console.WriteLine("Usage: LogginDemo CommandName Arguments");
            Console.WriteLine("Command:");
            foreach (var command in availableCommands)
            {
                Console.WriteLine($"    {command.Desciption}");
            }
        }
    }
}
