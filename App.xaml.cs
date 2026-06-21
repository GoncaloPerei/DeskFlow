using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Net.NetworkInformation;
using System.Windows;
using DeskFlow.Models;

namespace DeskFlow
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ObservableCollection<Ticket> lstTickets = new ObservableCollection<Ticket>();

        public static ObservableCollection<Person> lstUsers { get; set; } = new ObservableCollection<Person>();

        public App()
        {
            PopulateMockData();
        }

        private void PopulateMockData()
        {
            Technician tech1 = new Technician
            {
                Name = "Eng. Nuno Silva",
                Email = "nuno.silva@deskflow.com",
                Password = "123",
                Specialization = "Networks",
                IsAdmin = true
            };

            Technician tech2 = new Technician
            {
                Name = "Ana Costa",
                Email = "ana.costa@deskflow.com",
                Password = "123",
                Specialization = "Hardware",
                IsAdmin = false
            };

            Customer cust1 = new Customer
            {
                Name = "Carlos Santos",
                Email = "carlos2000@gmail.com",
                Password = "123",
                CompanyName = "Acme Portugal"
            };

            Customer cust2 = new Customer
            {
                Name = "Maria Rodrigues",
                Email = "maria@inovacao.pt",
                Password = "123",
                CompanyName = "Inovação Digital"
            };

            lstUsers.Add(tech1);
            lstUsers.Add(tech2);
            lstUsers.Add(cust1);
            lstUsers.Add(cust2);

            Ticket ticketTeste = new Ticket
            {
                Title = "Impressora de Redes Offline",
                Description = "A impressora do piso 2 deixou de responder aos pedidos da rede local.",
                Priority = "High",
                Customer = cust1,
                AssignedTechnician = tech2
            };

            lstTickets.Add(ticketTeste);
        }
    }

}
