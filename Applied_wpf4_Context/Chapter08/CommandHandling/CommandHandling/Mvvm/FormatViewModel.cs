using System.Windows.Input;

namespace CommandHandling.Mvvm
{
    public sealed class FormatViewModel : ObservableObject<FormatViewModel>
    {
        private string formattedText;
        private string originalText;

        public FormatViewModel()
        {
            FormatCommand = new MvvmCommand(
                (parameter) => { FormatText(); },
                (parameter) => { return !string.IsNullOrEmpty(OriginalText); })
                .AddListner<FormatViewModel>(this, x => x.OriginalText)
                .AddListner<FormatViewModel>(this, x => x.FormattedText);
        }

        public ICommand FormatCommand { get; private set; }

        public string OriginalText
        {
            get { return originalText; }
            set
            {
                originalText = value;
                OnPropertyChanged(vm => vm.OriginalText);
            }
        }

        public string FormattedText
        {
            get { return formattedText; }
            set
            {
                formattedText = value;
                OnPropertyChanged(vm => vm.FormattedText);
            }
        }

        private void FormatText()
        {
            FormattedText = string.Format("Formatted: {0}", OriginalText);
        }
    }
}