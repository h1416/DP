using System;

namespace Command.Commands
{
    class UpdateQuantityCommand : ICommand, ICommandFactory
    {
        public int NewQuantity { get; set; }
        public void Execute()
        {
            // simulate updating a database
            const int oldQuantity = 5;
            Console.WriteLine("DATABASE: Updated");

            // simulate logging
            Console.WriteLine($"LOG: Updated order quantity from {oldQuantity} to {NewQuantity}");
        }

        public string CommandName { get { return "UpdateQuantity"; } }

        public string Desciption { get { return "UpdateQuantity number"; } }

        public ICommand MakeCommand(string[] arguments)
        {
            return new UpdateQuantityCommand { NewQuantity = int.Parse(arguments[1]) };
        }
    }
}
