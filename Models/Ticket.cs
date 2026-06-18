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

        #region Constructor

        public Ticket()
        {
            _idTicket = Guid.NewGuid();
            setTitle("");
            setDescription("");
            _createdAt = DateTime.Now;
            setStatus("");
            setPriority("");
            setCustomer(new Customer());
            setAssignedTechnician(null);
        }

        public Guid getTicketId() { return _idTicket; }

        public void setTitle(string title)
        {
            _title = title.Trim();
            if (_title.Length == 0)
            {
                _title = "Untitled";
            }
        }

        public string getTitle() { return _title; }

        public void setDescription(string description)
        {
            _description = description.Trim();
            if (_description.Length == 0)
            {
                _description = "No description provided.";
            }
        }

        public string getDescription() { return _description; }

        public DateTime getCreatedAt() { return _createdAt; }

        public void setStatus(string status)
        {
            _status = status.Trim();
            if (_status.Length == 0)
            {
                _status = "Open";
            }
        }

        public string getStatus() { return _status; }    
        
        public void setPriority(string priority)
        {
            _priority = priority.Trim();
            if (_priority.Length == 0)
            {
                _priority = "Medium";
            }
        }

        public string getPriority() { return _priority; }

        public void setCustomer(Customer customer)
        {
            _customer = customer;
        }

        public Customer getCustomer() { return _customer; }

        public void setAssignedTechnician(Technician? technician)
        {
            _assignedTechnician = technician;
        }

        public Technician? getAssignedTechnician() { return _assignedTechnician; }

        #endregion

        #region MS Properties (Controlo por Propriedade para o WPF)

        public Guid TicketId
        {
            get { return getTicketId(); }
        }

        public DateTime CreatedAt
        {
            get { return getCreatedAt(); }
        }

        public string Title
        {
            get { return getTitle(); }
            set { setTitle(value); }
        }

        public string Description
        {
            get { return getDescription(); }
            set { setDescription(value); }
        }

        public string Status
        {
            get { return getStatus(); }
            set { setStatus(value); }
        }

        public string Priority
        {
            get { return getPriority(); }
            set { setPriority(value); }
        }

        public Customer Customer
        {
            get { return getCustomer(); }
            set { setCustomer(value); }
        }

        public Technician? AssignedTechnician
        {
            get { return getAssignedTechnician(); }
            set { setAssignedTechnician(value); }
        }

        #endregion

    }
}
