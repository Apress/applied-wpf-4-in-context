using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandHandling.Command_Pattern
{
    public sealed class Invoker
    {
        private CommandBase command;

        public Invoker(CommandBase command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            if (command.CanExecute())
            {
                command.Execute();
            }
        }
    }
}
