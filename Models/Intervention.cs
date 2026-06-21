using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
            Text = "";
            _createdAt = DateTime.Now;
            Person = new Person ();
            Ticket = new Ticket();
        }

        #endregion

        #region Getters and Setters

        public Guid Id
        {
            get { return _idIntervention; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value.Trim();
                if (_text.Length == 0)
                {
                    _text = "No description provided.";
                }
            }
        }

        public Person Person
        {
            get { return _person; }
            set { _person = value; }
        }

        public Ticket Ticket
        {
            get { return _ticket; }
            set { _ticket = value; }
        }

        #endregion
    }
}
