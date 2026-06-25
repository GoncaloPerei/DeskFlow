using DeskFlow.Views.Customer;
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

namespace DeskFlow.Views.Technician
{
    /// <summary>
    /// Interaction logic for TechnicianMainWindow.xaml
    /// </summary>
    public partial class TechnicianMainWindow : Window
    {
        public TechnicianMainWindow()
        {
            InitializeComponent();

            loadTickets();
        }

        private void loadTickets()
        {
            MainContentArea.Content = new TechnicianTicketsControl();
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAllTickets_Click(object sender, RoutedEventArgs e)
        {
            loadTickets();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
