using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskFlow.Models
{
    public class Technician : Person
    {
        private string _specialization; // Specialization of the technician. If not provided, defaults to "General".

        #region Constructor

        public Technician() : base()
        {
            Specialization = "";
        }

        #endregion

        #region Getters and Setters

        public string Specialization
        {
            get { return _specialization; }
            set {
                _specialization = value.Trim();
                if (_specialization.Length == 0)
                {
                    _specialization = "General";
                }
            }
        }

        #endregion
    }
}
