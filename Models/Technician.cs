using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskFlow.Models
{
    public class Technician
    {
        private string _specialization; // Specialization of the technician. If not provided, defaults to "General".
        private bool _isAdmin; // Indicates whether the technician has administrative privileges. Defaults to false.

        #region Constructor

        public Technician()
        {
            setSpecialization("");
        }

        #endregion

        #region Getters and Setters

        public void setSpecialization(string specialization)
        {
            _specialization = specialization.Trim();
            if (_specialization.Length == 0)
            {
                _specialization = "General";
            }
        }

        public string getSpecialization() { return _specialization; }

        public void setIsAdmin(bool isAdmin)
        {
            _isAdmin = isAdmin;
        }

        public bool getIsAdmin() { return _isAdmin; }

        #endregion

        #region MS Properties (Controlo por Propriedade para o WPF)

        public string Specialization
        {
            get { return getSpecialization(); }
            set { setSpecialization(value); }
        }

        public bool IsAdmin
        {
            get { return getIsAdmin(); }
            set { setIsAdmin(value); }
        }

        #endregion
    }
}
