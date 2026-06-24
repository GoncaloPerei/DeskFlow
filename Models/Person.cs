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
        private string _email; // Email address of the person.
        private string _password; // Password for the person's account. (Note: In a real application, passwords should be hashed and not stored in plain text.)
        private DateTime _createdAt; // Date and time when the person was created.
        private DateTime _lastAccess; // Date and time when the person last accessed the system.

        #region Constructor

        public Person()
        {
            _idPerson = Guid.NewGuid();
            Name = "Default User";
            Email = "default@deskflow.com";
            Password = "Mudame123!";
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
                string email = value.Trim();
                if (email.Length == 0)
                {
                    throw new ArgumentException("O email não pode ser vazio.");
                }

                try
                {
                    var mailAddress = new MailAddress(email);
                    _email = email;
                }
                catch (FormatException)
                {
                    throw new ArgumentException("O email introduzido não tem um formato válido (ex: utilizador@dominio.com).");
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
                    throw new ArgumentException("A password não pode ser vazia.");
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
