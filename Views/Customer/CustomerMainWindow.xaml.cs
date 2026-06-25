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

namespace DeskFlow.Views.Customer
{
    /// <summary>
    /// Interaction logic for CustomerMainWindow.xaml
    /// </summary>
    public partial class CustomerMainWindow : Window
    {
        public CustomerMainWindow()
        {
            InitializeComponent();

            loadTickets();
        }

        private void loadTickets()
        {
            MainContentArea.Content = new CustomerTicketsControl();
        }

        private void btnTickets_Click(object sender, RoutedEventArgs e)
        {
            txtPageTitle.Text = "My Tickets";

            loadTickets();
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            txtPageTitle.Text = "My Profile";

            MainContentArea.Content = new CustomerProfileControl();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                 "Are you sure you want to logout?",
                 "Logout",
                 MessageBoxButton.YesNo,
                 MessageBoxImage.Question
            );

            if (result == MessageBoxResult.Yes)
            {
                App.loggedUser = null;

                LoginWindow loginWin = new LoginWindow();
                loginWin.Show();

                this.Close();
            }
        }
    }
}
