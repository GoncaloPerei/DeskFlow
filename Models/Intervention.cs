using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskFlow.Models
{
    public class Intervention
    {
        private Guid _idIntervention; // Unique identifier of the intervention.
        private string _text; // Text description of the intervention. If not provided, defaults to "No description provided."
        private DateTime _createdAt; // Date and time when the intervention was created.
        private Person _person; // Person associated with the intervention.
        private Ticket _ticket; // Ticket associated with the intervention.

        #region Constructor

        public Intervention()
        {
            _idIntervention = Guid.NewGuid();
            setText("");
            _createdAt = DateTime.Now;
            setPerson(new Person());
            setTicket(new Ticket());
        }

        #endregion

        #region Getters and Setters

        public Guid getInterventionId() { return _idIntervention; }

        public void setText(string text)
        {
            _text = text.Trim();
            if (_text.Length == 0)
            {
                _text = "No description provided.";
            }
        }   

        public string getText() { return _text; }

        public DateTime getCreatedAt() { return _createdAt; }

        public void setPerson(Person person)
        {
            _person = person;
        }

        public Person getPerson() { return _person; }

        public void setTicket(Ticket ticket)
        {
            _ticket = ticket;
        }

        public Ticket getTicket() { return _ticket; }

        #endregion

        #region MS Properties (Controlo por Propriedade para o WPF)

        public Guid Id
        {
            get { return getInterventionId(); }
        }

        public DateTime CreatedAt
        {
            get { return getCreatedAt(); }
        }

        public string Text
        {
            get { return getText(); }
            set { setText(value); }
        }

        public Person Person
        {
            get { return getPerson(); }
            set { setPerson(value); }
        }

        public Ticket Ticket
        {
            get { return getTicket(); }
            set { setTicket(value); }
        }

        #endregion
    }
}
