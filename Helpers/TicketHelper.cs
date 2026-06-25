using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskFlow.Helpers
{
    public class TicketHelper
    {
        public void Insert(Models.Ticket ticket)
        {
            App.lstTickets.Add(ticket);
        }

        public void Update(Models.Ticket ticket)
        {
            var existingTicket = App.lstTickets.FirstOrDefault(t => t.TicketId == ticket.TicketId);
            if (existingTicket != null)
            {
                existingTicket.Title = ticket.Title;
                existingTicket.Description = ticket.Description;
                existingTicket.Status = ticket.Status;
                existingTicket.Priority = ticket.Priority;
                existingTicket.AssignedTechnician = ticket.AssignedTechnician;
            }
        }
    }
}
