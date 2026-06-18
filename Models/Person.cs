using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            setName("");
            setEmail("");
        }

        #endregion

        #region Getters and Setters

        public Guid getPersonId()
        {
            return _idPerson;
        }

        public void setName(string name)
        {
            _fullName = name.Trim();
            if(_fullName.Length == 0)
            {
                _fullName = "John Doe";
            }
        }

        public string getName() { return _fullName; }

        public void setEmail(string email)
        {
            _email = email.Trim();
            if (_email.Length == 0)
            {
                _email = "johndoe@email.com";
            }
        }

        public string getEmail() { return _email; }

        #endregion

        #region MS Properties (Controlo por Propriedade para o WPF)

        public Guid IdPerson
        {
            get { return getPersonId(); }
        }

        public string Name
        {
            get { return getName(); }
            set { setName(value); }
        }

        public string Email
        {
            get { return getEmail(); }
            set { setEmail(value); }
        }

        public string CreatedAt
        {
            get { return _createdAt.ToString("yyyy-MM-dd HH:mm:ss"); }
        }

        #endregion
    }
}
