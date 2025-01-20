using System.Windows;
using System.Windows.Controls;

namespace DynamicViewExample.Views
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void OnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            // TODO
            System.Diagnostics.Debug.WriteLine("Clicked the sign-up button");
        }

        private void GoToSignIn_Click(object sender, RoutedEventArgs e)
            => AppManager.ShowView(new Login());
    }
}
