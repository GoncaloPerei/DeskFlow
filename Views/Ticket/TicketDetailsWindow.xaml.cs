using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DeskFlow.Models;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DeskFlow.Views.Ticket
{
    /// <summary>
    /// Interaction logic for TicketDetailsWindow.xaml
    /// </summary>
    public partial class TicketDetailsWindow : Window
    {
        private Models.Ticket _currentTicket;

        public TicketDetailsWindow(Models.Ticket selectedTicket)
        {
            InitializeComponent();

            _currentTicket = selectedTicket;

            loadTicket();
        }

        private void checkStatus()
        {
            if (_currentTicket.Status == "Closed")
            {
                txtReply.IsEnabled = false;
                txtReply.Text = "This ticket is closed.";
                btnSendReply.IsEnabled = false;
                btnCloseTicket.IsEnabled = false;
                btnCloseTicket.Content = "🔒 Closed";
            }
            else if (_currentTicket.Status == "Open")
            {
                txtReply.IsEnabled = true;
                btnSendReply.IsEnabled = true;
                btnCloseTicket.IsEnabled = true;
                btnCloseTicket.Content = "🔒 Close Ticket";
            }
        }

        private void loadTicket()
        {
            lblTicketTitle.Text = _currentTicket.Title;
            lblCreatedAt.Text = _currentTicket.CreatedAt.ToString("dd/MM/yyyy HH:mm");
            lblDescription.Text = _currentTicket.Description;
            lblUrgency.Text = _currentTicket.Priority.ToUpper();
            lblStatus.Text = _currentTicket.Status;

            var ticketInterventions = App.lstInterventions
                .Where(i => i.Ticket != null && i.Ticket.TicketId == _currentTicket.TicketId)
                .ToList();

            lbInterventions.ItemsSource = ticketInterventions;

            checkStatus();
        }

        private void btnSendReply_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCloseTicket_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show(
                "Do you really want to close this ticket??",
                "Close Ticket",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
            );

            if (resultado == MessageBoxResult.Yes)
            {
                _currentTicket.Status = "Closed";

                MessageBox.Show("The ticket has been closed.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                loadTicket();
            }
        }

        private void txtReply_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
