using Notepad.Model;
using Notepad.Services;
using Notepad.Utilities;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace Notepad
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {
            string cellphoneNumber = CellphoneNumberTextBox.Text;
            string password = PasswordBox.Password.ToString();
            if (!string.IsNullOrEmpty(cellphoneNumber) && !string.IsNullOrEmpty(password))
            {
                password = Utilities.Utilities.ComputeSHA256Hash(password);
                var user = new User()
                {
                    CellphoneNumber = cellphoneNumber,
                    Password = password
                };
                Login(user);
            }
            else
            {
                MessageBox.Show(Properties.Resources.CHECK_ENTERED_INFORMATION_LABEL,
                    Properties.Resources.EMPTY_FIELDS_LABEL);
            }
        }

        private async void Login(User user)
        {
            Response response = await AccessService.Login(user);
            if (!response.Error)
            {
                user = response.User;
                MessageBox.Show(string.Concat(Properties.Resources.WELCOME_LABEL, user, "!"));
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void SignUpButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}