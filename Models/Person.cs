using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DeskFlow.Models
{
    public class Person
    {
        private Guid _idPerson; // Unique identifier of the person.
        private string _fullName; // Full name of the person. If not provided, defaults to "John Doe".
        private string _email; // Email address of the person. If not provided, defaults to "johndoe@email.com".
        private string _password; // Password for the person's account. If not provided, defaults to "123".
        private DateTime _createdAt; // Date and time when the person was created.
        private DateTime _lastAccess; // Date and time when the person last accessed the system.

        #region Constructor

        public Person()
        {
            _idPerson = Guid.NewGuid();
            Name = "";
            Email = "";
            Password = "";
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

        public string Password // Rever logica de negocio de password.
        {
            get { return _password; }
            set {
                _password = value.Trim();
                if (_password.Length == 0)
                {
                    _password = "123";
                }
            }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        #endregion
    }
}
