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

        public static ObservableCollection<Person> lstUsers = new ObservableCollection<Person>();

        public static List<Intervention> lstInterventions = new List<Intervention>();

        public static Person loggedUser = new Person();

        public App()
        {
            PopulateMockData();
        }

        private void PopulateMockData()
        {
            // ==================== 1. CRIAR TÉCNICOS ====================

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

            lstUsers.Add(tech1);
            lstUsers.Add(tech2);

            // ==================== 2. CRIAR CLIENTES ====================

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

            lstUsers.Add(cust1);
            lstUsers.Add(cust2);

            // ==================== 3. CRIAR TICKETS (DADOS DE TESTE) ====================

            Ticket t1 = new Ticket
            {
                Title = "Impressora de Redes Offline",
                Description = "A impressora do piso 2 deixou de responder aos pedidos da rede local.",
                Priority = "High",
                Status = "Aberto",
                Customer = cust1,
                AssignedTechnician = tech2 // Atribuído à Ana Costa
            };

            Ticket t2 = new Ticket
            {
                Title = "Erro no Switch Principal",
                Description = "O switch do bastidor A está a perder pacotes intermitentemente.",
                Priority = "High",
                Status = "Aberto",
                Customer = cust2,
                AssignedTechnician = tech1 // Atribuído ao Eng. Nuno Silva
            };

            // --- TICKETS DISPONÍVEIS / SEM TÉCNICO ---

            Ticket t3 = new Ticket
            {
                Title = "Configuração de VPN",
                Description = "O novo colaborador precisa de acessos à VPN para trabalhar a partir de casa.",
                Priority = "Medium",
                Status = "Aberto",
                Customer = cust1,
                AssignedTechnician = null // 🔓 Disponível para capturar!
            };

            Ticket t4 = new Ticket
            {
                Title = "Ecrã Azul no Portátil (BSOD)",
                Description = "O computador bloqueia com ecrã azul 5 minutos após iniciar o Windows.",
                Priority = "Low",
                Status = "Aberto",
                Customer = cust2,
                AssignedTechnician = null // 🔓 Disponível para capturar!
            };

            Ticket t5 = new Ticket
            {
                Title = "Recuperação de Cópia de Segurança",
                Description = "Foi apagada uma pasta importante por engano no servidor partilhado.",
                Priority = "High",
                Status = "Aberto",
                Customer = cust1,
                AssignedTechnician = null // 🔓 Disponível para capturar!
            };

            lstTickets.Add(t1);
            lstTickets.Add(t2);
            lstTickets.Add(t3);
            lstTickets.Add(t4);
            lstTickets.Add(t5);
        }
    }

}
