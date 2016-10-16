using System.ComponentModel;
using System.Windows.Input;

namespace UIPatterns.MVVM
{
    public sealed class CalculatorViewModel : INotifyPropertyChanged
    {
        public ICommand CalculateCommand { get; private set; }

        private CalculatorModel model;

        public CalculatorViewModel()
        {
            this.model = new CalculatorModel();
            this.CalculateCommand = new MvvmCommand(
                param => model.Calculate(),
                param => NumberA != 0 && NumberB != 0)
                .AddListner<CalculatorViewModel>(this, x => x.NumberA);
        }

        public CalculatorViewModel(CalculatorModel model)
        {
            this.model = model;
        }

        public int NumberA
        {
            get { return this.model.NumberA; }
            set
            {
                this.model.NumberA = value;
                OnPropertyChanged("NumberA");
            }
        }

        public int NumberB
        {
            get { return this.model.NumberB; }
            set
            {
                this.model.NumberB = value;
                OnPropertyChanged("NumberB");
            }
        }

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}