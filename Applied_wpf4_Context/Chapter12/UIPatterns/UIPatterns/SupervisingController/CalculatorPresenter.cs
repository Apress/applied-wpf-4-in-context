namespace UIPatterns.SupervisingController
{
    public sealed class CalculatorPresenter
    {
        private readonly ICalculatorView view;

        public CalculatorPresenter(ICalculatorView view)
        {
            this.view = view;
        }

        public void Calculate()
        {
            CalculatorModel model = this.view.Model;
            model.Calculate();
        }
    }
}