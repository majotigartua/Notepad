using Notepad.Model;
using Notepad.Services;
using System.Windows;
using System.Windows.Controls;

namespace Notepad.Views
{
    public partial class SignUpWindow : Window
    {
        public SignUpWindow()
        {
            InitializeComponent();
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AcceptButtonClick(object sender, RoutedEventArgs e)
        {
            if (!CheckEmptyFields())
            {
                string name = NameTextBox.Text;
                string paternalSurname = PaternalSurnameTextBox.Text;
                string maternalSurname = MaternalSurnameTextBox.Text;
                string cellphoneNumber = CellphoneNumberTextBox.Text;
                string password = PasswordBox.Password.ToString();
                password = Utilities.Utilities.ComputeSHA256Hash(password);
                var user = new User()
                {
                    Name = name,
                    PaternalSurname = paternalSurname,
                    MaternalSurname = maternalSurname,
                    CellphoneNumber = cellphoneNumber,
                    Password = password
                };
                SignUp(user);
            }
            else
            {
                MessageBox.Show(Properties.Resources.CHECK_ENTERED_INFORMATION_LABEL,
                    Properties.Resources.EMPTY_FIELDS_LABEL);
            }
        }

        private bool CheckEmptyFields()
        {
            return string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(PaternalSurnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(MaternalSurnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(CellphoneNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordBox.Password.ToString());
        }

        private async void SignUp(User user)
        {
            Response response = await AccessService.SignUp(user);
            MessageBox.Show(response.ToString());
            if (!response.Error)
            {
                Close();
            }
        }
    }
}