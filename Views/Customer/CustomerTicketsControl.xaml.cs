using DeskFlow.Views.Ticket;
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
    /// Interaction logic for CustomerTicketsControl.xaml
    /// </summary>
    public partial class CustomerTicketsControl : UserControl
    {
        public CustomerTicketsControl()
        {
            InitializeComponent();

            LoadUserTickets();
        }

        private void LoadUserTickets()
        {
            if (App.loggedUser == null) return;

            var tickets = App.lstTickets
                .Where(t => t.Customer.Email.Equals(App.loggedUser.Email, System.StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgTickets.ItemsSource = tickets;
        }

        private void dgTickets_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedTicket = dgTickets.SelectedItem as Models.Ticket;

            TicketDetailsWindow detailsWindow = new TicketDetailsWindow(selectedTicket);

            detailsWindow.ShowDialog();

            dgTickets.Items.Refresh();
        }
    }
}
