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
            MessageBox.Show("Redirecting to Registration window...", "Navigation", MessageBoxButton.OK, MessageBoxImage.None);
        }

        private void BtnGoToRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow regisWindow = new RegisterWindow();

            regisWindow.Show();

            this.Close();
        }
    }
}
