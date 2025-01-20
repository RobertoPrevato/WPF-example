using DynamicViewExample.Views;
using System.Windows;

namespace DynamicViewExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainContentControl.Content = new Login(); // initialize with the login screen

            // TODO: it would be possible to store the last user context in a App Folder and
            // restore the context across application restarts (and better UX)
        }
    }
}
