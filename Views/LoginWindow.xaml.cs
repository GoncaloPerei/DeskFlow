using DeskFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DeskFlow.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string _email = txtEmail.Text.Trim();
            string _password = txtPassword.Password.Trim();

            foreach (Person p in App.lstUsers)
            {
                if (p.Email.Equals(_email, StringComparison.OrdinalIgnoreCase) && p.Password == _password)
                {
                    App.loggedUser = p;
                    break;
                }
            }

            if (App.loggedUser is Technician tech)
            {
                MessageBox.Show($"Welcome, Technician {tech.Name}!",
                                "Log in successfuly", MessageBoxButton.OK, MessageBoxImage.Information);

                return;
            }
            else if (App.loggedUser is Customer cust)
            {
                MessageBox.Show($"Welcome, Customer: {cust.Name}!",
                                "Log in successfuly", MessageBoxButton.OK, MessageBoxImage.Information);

                return;
            }

            MessageBox.Show("Email or password incorrect!", "Log in Failed", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void BtnGoToRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow regisWindow = new RegisterWindow();

            regisWindow.Show();

            this.Close();
        }
    }
}
