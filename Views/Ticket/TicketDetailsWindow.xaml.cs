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
using DeskFlow.Helpers;

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
            lblTechnicianName.Text = _currentTicket.AssignedTechnician != null ? _currentTicket.AssignedTechnician.Name : "Unassigned";

            loadInterventions();

            checkStatus();
        }

        private void loadInterventions()
        {
            var ticketInterventions = App.lstInterventions
                .Where(i => i.Ticket != null && i.Ticket.TicketId == _currentTicket.TicketId)
                .ToList();
            lbInterventions.ItemsSource = ticketInterventions;
        }

        private void btnSendReply_Click(object sender, RoutedEventArgs e)
        {
            string _text = txtReply.Text.Trim();

            if (_text.Length == 0)
            {
                MessageBox.Show("Message cannot be empty!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            InterventionHelper iH = new InterventionHelper();

            Intervention i = new Intervention();

            i.Text = _text;
            i.Person = App.loggedUser;
            i.Ticket = _currentTicket;

            iH.Insert(i);

            MessageBox.Show("Intervention sent successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            txtReply.Text = "";

            loadInterventions();
        }

        private void btnCloseTicket_Click(object sender, RoutedEventArgs e)
        {
            TicketHelper tH = new TicketHelper();

            MessageBoxResult resultado = MessageBox.Show(
                "Do you really want to close this ticket??",
                "Close Ticket",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
            );

            if (resultado == MessageBoxResult.Yes)
            {
                _currentTicket.Status = "Closed";

                tH.Update(_currentTicket);

                MessageBox.Show("The ticket has been closed.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                loadTicket();
            }
        }

        private void txtReply_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
