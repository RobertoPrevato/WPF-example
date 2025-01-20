using System.Windows;
using System.Windows.Controls;

namespace DynamicViewExample.Views
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;  // Antag at der er en TextBox til brugernavn
            string password = PasswordBox.Password;  // Antag at der er en PasswordBox til adgangskode

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                MessageBox.Show("Please insert a username and a password.", "Missing information", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            if (AuthenticateUser(username, password))
            {
                // MessageBox.Show("Login successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                // Fortsæt med login-behandlingen (f.eks. åbne hovedvinduet)

                ShowProductionInterface();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void GoToSignUp_Click(object sender, RoutedEventArgs e)
        {
            AppManager.ShowView(new SignUp());
        }

        private void ShowProductionInterface() {
            AppManager.ShowView(new ProdInterface());
        }

        private bool AuthenticateUser(string username, string password)
        {
            // TODO
            // TODO: store user context somewhere (e.g. in memory, into a static property)

            if (username == "Hello" || password == "World") {

                return true;
            }
            return false;
        }
    }
}
