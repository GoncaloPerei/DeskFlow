using DeskFlow.Helpers;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeskFlow.Views.Technician
{
    /// <summary>
    /// Interaction logic for TechnicianTicketsControl.xaml
    /// </summary>
    public partial class TechnicianTicketsControl : UserControl
    {
        private Models.Technician _currentTech;

        public TechnicianTicketsControl()
        {
            InitializeComponent();

            _currentTech = App.loggedUser as Models.Technician;

            LoadTickets();
        }

        private void LoadTickets()
        {
            if (App.lstTickets == null) return;

            dgMyTickets.ItemsSource = null;
            dgMyTickets.ItemsSource = App.lstTickets
                .Where(t => t.AssignedTechnician != null && t.AssignedTechnician.IdPerson == _currentTech.IdPerson)
                .ToList();

            dgAvailableTickets.ItemsSource = null;
            dgAvailableTickets.ItemsSource = App.lstTickets
                .Where(t => t.AssignedTechnician == null)
                .ToList();
        }

        private void dgAvailableTickets_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedTicket = dgAvailableTickets.SelectedItem as Models.Ticket;

            if (selectedTicket == null) return;

            TicketHelper tH = new TicketHelper();

            MessageBoxResult result = MessageBox.Show(
                $"Do you want to link the ticket - {selectedTicket.Title} to your profile?",
                "Assign Ticket",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                selectedTicket.AssignedTechnician = _currentTech;

                tH.Update(selectedTicket);

                MessageBox.Show("Ticket successfully assigned! You can now interact with the customer.",
                                "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                LoadTickets();
            }

        }

        private void dgMyTickets_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedTicket = dgMyTickets.SelectedItem as Models.Ticket;

            if (selectedTicket != null)
            {
                TicketDetailsWindow detailsTicketWindow = new TicketDetailsWindow(selectedTicket);
                detailsTicketWindow.Owner = Window.GetWindow(this);
                detailsTicketWindow.ShowDialog();
            }

            LoadTickets();
        }
    }
}
