using System.Diagnostics;
using System.Windows;

namespace MainMenu
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShooterGame_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("ShooterGame.exe");
            Application.Current.Shutdown();
        }

        private void RunnerGame_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("RunnerGame.exe");
            Application.Current.Shutdown();
        }
    }
}
