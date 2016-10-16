using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandHandling.Command_Pattern
{
    public sealed class ConcreteCommand : CommandBase
    {
        public ConcreteCommand(Receiver receiver) 
            : base(receiver)
        {
        }

        #region Overrides of CommandBase

        public override void Execute()
        {
            this.receiver.ExecuteAction();
        }

        public override bool CanExecute()
        {
            return this.receiver != null;
        }

        #endregion
    }
}
