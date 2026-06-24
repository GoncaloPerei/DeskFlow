using DeskFlow.Models;
using DeskFlow.Helpers;
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
    /// Lógica interna para RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWin = new LoginWindow();
            loginWin.Show();

            this.Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            PersonHelper cH = new PersonHelper();

            string _name = txtFullName.Text.Trim();
            string _email = txtEmail.Text.Trim();
            string _password = txtPassword.Password.Trim();
            string _confirmPass = txtConfirmPassword.Password.Trim();

            if (_password != _confirmPass)
            {
                MessageBox.Show("As passwords introduzidas não coincidem!", "Erro no Registo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                Customer newClient = new Customer();

                newClient.Name = _name;
                newClient.Email = _email;
                newClient.Password = _password;

                cH.Insert(newClient);

                MessageBox.Show("Conta criada com sucesso! Já pode fazer login.", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);

                LoginWindow loginWin = new LoginWindow();
                loginWin.Show();

                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Validação", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
