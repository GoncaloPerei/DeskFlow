using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskFlow.Models
{
    public class Ticket
    {
        public Guid _idTicket; // Unique identifier of the ticket.
        public string _title; // Title of the ticket. If not provided, defaults to "Untitled".
        public string _description; // Description of the ticket. If not provided, defaults to "No description provided.".
        public DateTime _createdAt; // Date and time when the ticket was created.
        public string _status; // Status of the ticket. If not provided, defaults to "Open".
        public string _priority; // Priority of the ticket. If not provided, defaults to "Medium".
        public Customer _customer; // Customer associated with the ticket.
        public Technician _assignedTechnician; // Technician assigned to the ticket. If not provided, defaults to null.
        public Person _closedBy; // Person who closed the ticket. If not provided, defaults to null.

        #region Constructor

        public Ticket()
        {
            _idTicket = Guid.NewGuid();
            Title = "";
            Description = "";
            _createdAt = DateTime.Now;
            Status = "";
            Priority = "";
            Customer = new Customer();
            AssignedTechnician = new Technician();
        }

        #endregion

        #region Getters and Setters

        public Guid TicketId
        {
            get { return _idTicket; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public string Title
        {
            get { return _title; }
            set {
                _title = value.Trim();
                if (_title.Length == 0)
                {
                    _title = "Untitled";
                }
            }
        }

        public string Description
        {
            get { return _description; }
            set {
                _description = value.Trim();
                if (_description.Length == 0)
                {
                    _description = "No description provided.";
                }
            }
        }

        public string Status
        {
            get { return _status; }
            set {
                _status = value.Trim();
                if (_status.Length == 0)
                {
                    _status = "Open";
                }
            }
        }

        public string Priority
        {
            get { return _priority; }
            set {
                _priority = value.Trim();
                if (_priority.Length == 0)
                {
                    _priority = "Medium";
                }
            }
        }

        public Customer Customer
        {
            get { return _customer; }
            set {
                _customer = value;
            }
        }

        public Technician? AssignedTechnician
        {
            get { return _assignedTechnician; }
            set { _assignedTechnician = value; }
        }

        public Person? ClosedBy
        {
            get { return _closedBy; }
            set { _closedBy = value; }
        }

        #endregion

    }
}
