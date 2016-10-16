using System;
using System.Windows;

namespace UIPatterns.SupervisingController
{
    /// <summary>
    /// Interaction logic for SupervisingController.xaml
    /// </summary>
    public partial class SupervisingController : Window, ICalculatorView
    {
        private readonly CalculatorPresenter presenter;

        public SupervisingController()
        {
            InitializeComponent();
            this.presenter = new CalculatorPresenter(this);
        }

        #region ICalculatorView Members

        public CalculatorModel Model
        {
            get { return DataContext as CalculatorModel; }
            set { DataContext = value; }
        }

        public void Calculate(object sender, EventArgs args)
        {
            this.presenter.Calculate();
        }

        #endregion
    }
}