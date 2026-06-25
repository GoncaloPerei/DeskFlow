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
    }
}
