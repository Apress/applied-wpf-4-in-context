using System.Windows;
using System.Windows.Input;
using CommandHandling.Mvvm;

namespace CommandHandling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static RoutedCommand CustomCommand = new RoutedCommand();

        public static ICommand MvvmCommand = new MvvmCommand(
                (parameter)
                => MessageBox.Show("Mvvm Command"), (parameter) => true);

        public MainWindow()
        {
            InitializeComponent();
            CommandBindings.Add(
                new CommandBinding(ApplicationCommands.Cut,
                                   (sender, args) => { MessageBox.Show("Cut command"); },
                                   (sender, args) => { args.CanExecute = true; }));
            CommandBindings.Add(
                new CommandBinding(ApplicationCommands.Copy,
                                   (sender, args) => { MessageBox.Show("Copy command"); }));
            CommandBindings.Add(
                new CommandBinding(ApplicationCommands.Paste,
                                   (sender, args) => { MessageBox.Show("Paste command"); }));
        }

        private void CustomExecuted(object sender, ExecutedRoutedEventArgs e)
        {
        }

        private void CustomCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}