using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DeskFlow.Models
{
    public class Customer : Person
    {
        private string _nif; // Tax Identification Number of the customer. If not provided, defaults to "999999999".
        private string _companyName; // Company name of the customer. If not provided, defaults to "Individual Client".

        #region Constructor

        public Customer() : base()
        {
            Nif = "";
            CompanyName = "";
        }

        #endregion

        #region Getters and Setters

        public string Nif
        {
            get { return _nif; }
            set {
                _nif = value.Trim();
                if (_nif.Length == 0)
                {
                    _nif = "999999999";
                }
            }
        }

        public string CompanyName
        {
            get { return _companyName; }
            set {
                _companyName = value.Trim();
                if (_companyName.Length == 0)
                {
                    _companyName = "Individual Client";
                }
            }
        }

        #endregion

    }
}
