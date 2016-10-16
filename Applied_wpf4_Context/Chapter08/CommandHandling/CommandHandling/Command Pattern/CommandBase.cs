namespace CommandHandling.Command_Pattern
{
    public abstract class CommandBase
    {
        protected Receiver receiver;

        // Constructor
        protected CommandBase(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();

        public abstract bool CanExecute();
    }
}