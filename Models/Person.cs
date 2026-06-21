using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DeskFlow.Models
{
    public class Person
    {
        private Guid _idPerson; // Unique identifier of the person.
        private string _fullName; // Full name of the person. If not provided, defaults to "John Doe".
        private string _email; // Email address of the person.
        private DateTime _createdAt; // Date and time when the person was created.
        private DateTime _lastAccess; // Date and time when the person last accessed the system.

        #region Constructor

        public Person()
        {
            _idPerson = Guid.NewGuid();
            Name = "";
            Email = "";
        }

        #endregion

        #region Getters and Setters

        public Guid IdPerson
        {
            get { return _idPerson; }
        }

        public string Name
        {
            get { return _fullName; }
            set {
                _fullName = value.Trim();
                if (_fullName.Length == 0)
                {
                    _fullName = "John Doe";
                }
            }
        }

        public string Email
        {
            get { return _email; }
            set {
                _email = value.Trim();
                if (_email.Length == 0)
                {
                    _email = "johndoe@email.com";
                }
            }
        }

        public string CreatedAt
        {
            get { return _createdAt.ToString("yyyy-MM-dd HH:mm:ss"); }
        }

        #endregion
    }
}
