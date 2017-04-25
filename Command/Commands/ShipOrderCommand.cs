using System;

namespace Command.Commands
{
    class ShipOrderCommand : ICommand, ICommandFactory
    {
        public string CommandName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Desciption
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public ICommand MakeCommand(string[] arguments)
        {
            throw new NotImplementedException();
        }
    }
}
