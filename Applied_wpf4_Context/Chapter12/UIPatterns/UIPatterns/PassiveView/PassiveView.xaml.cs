using System;
using System.Windows;

namespace UIPatterns.PassiveView
{
    /// <summary>
    /// Interaction logic for PassiveView.xaml
    /// </summary>
    public partial class PassiveView : Window, ICalculatorView
    {
        private CalculatorPresenter presenter;

        public PassiveView()
        {
            InitializeComponent();
            this.presenter = new CalculatorPresenter(this);
            btnCalculate.Click += Calculate;
        }

        public void Calculate(object sender, EventArgs args)
        {
            this.presenter.Calculate();
        }

        #region Implementation of ICalculatorView

        public int NumberA
        {
            get { return Convert.ToInt32(txtA.Text); }
            set { txtA.Text = value.ToString(); }
        }

        public int NumberB
        {
            get { return Convert.ToInt32(txtB.Text); }
            set { txtB.Text = value.ToString(); }
        }


        #endregion
    }
}