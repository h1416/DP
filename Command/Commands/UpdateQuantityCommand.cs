using System;

namespace Command.Commands
{
    class UpdateQuantityCommand : ICommand
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
    }
}
