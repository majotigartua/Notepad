using Notepad.Model;
using Notepad.Services;
using System.Windows;

namespace Notepad.Views
{
    public partial class ActivateWindow : Window
    {
        public ActivateWindow()
        {
            InitializeComponent();
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AcceptButtonClick(object sender, RoutedEventArgs e)
        {
            string cellphoneNumber = CellphoneNumberTextBox.Text;
            string oneTimePassword = OneTimePasswordTextBox.Text;
            if (!string.IsNullOrWhiteSpace(cellphoneNumber) && !string.IsNullOrWhiteSpace(oneTimePassword))
            {
                var user = new User()
                {
                    CellphoneNumber = cellphoneNumber,
                    OneTimePassword = oneTimePassword
                };
                Activate(user);
            }
            else
            {
                MessageBox.Show(Properties.Resources.CHECK_ENTERED_INFORMATION_LABEL,
                    Properties.Resources.EMPTY_FIELDS_LABEL);
            }
        }

        private async void Activate(User user)
        {
            Response response = await AccessService.Activate(user);
            MessageBox.Show(response.Message);
            if (!response.Error)
            {
                Close();
            } 
            else
            {
                CellphoneNumberTextBox.Clear();
                OneTimePasswordTextBox.Clear();
            }
        }
    }
}