using System.Windows;
using System.Windows.Controls;

namespace DynamicViewExample
{
    internal static class AppManager
    {
        internal static void ShowView(UserControl control)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.MainContentControl.Content = control;
        }
    }
}
