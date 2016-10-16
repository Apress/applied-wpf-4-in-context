namespace UIPatterns.PassiveView
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
            CalculatorModel model = new CalculatorModel(view.NumberA, view.NumberB);
            model.Calculate();
        }
    }
}