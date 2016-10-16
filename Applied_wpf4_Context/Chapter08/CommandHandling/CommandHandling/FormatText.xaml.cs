using System.Windows;
using CommandHandling.Mvvm;

namespace CommandHandling
{
    /// <summary>
    /// Interaction logic for FormatText.xaml
    /// </summary>
    public partial class FormatText : Window
    {
        public FormatText()
        {
            InitializeComponent();
            DataContext = new FormatViewModel();
        }
    }
}