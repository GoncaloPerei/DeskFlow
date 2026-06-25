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

namespace DeskFlow.Views.Ticket
{
    /// <summary>
    /// Interaction logic for CreateTicketWindow.xaml
    /// </summary>
    public partial class CreateTicketWindow : Window
    {
        public CreateTicketWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string _title = txtTitle.Text.Trim();
            string _description = txtDescription.Text.Trim();
            string _priority = (cmbPriority.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "Low";

            Helpers.TicketHelper tH = new Helpers.TicketHelper();

            Models.Ticket newTicket = new Models.Ticket();

            newTicket.Title = _title;
            newTicket.Description = _description;
            newTicket.Status = "Open";
            newTicket.Priority = _priority;
            newTicket.Customer = (Models.Customer)App.loggedUser;

            tH.Insert(newTicket);

            MessageBox.Show("Ticket successfully submitted!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            this.DialogResult = true;
            this.Close();
        }
    }
}
