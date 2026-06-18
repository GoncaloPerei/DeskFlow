using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskFlow.Models
{
    public class Customer : Person
    {
        private string _nif; // Tax Identification Number of the customer. If not provided, defaults to "999999999".
        private string _companyName; // Company name of the customer. If not provided, defaults to "Individual Client".
        private string _address; // Address of the customer. If not provided, defaults to "N/A".

        #region Constructor

        public Customer() : base()
        {
            setNif("");
            setCompanyName("");
            setAddress("");
        }

        #endregion

        #region Getters and Setters

        public void setNif(string nif)
        {
            _nif = nif.Trim();
            if (_nif.Length == 0)
            {
                _nif = "999999999";
            }
        }

        public string getNif() { return _nif; }

        public void setCompanyName(string companyName)
        {
            _companyName = companyName.Trim();
            if (_companyName.Length == 0)
            {
                _companyName = "Individual Client";
            }
        }

        public string getCompanyName() { return _companyName; }

        public void setAddress(string address)
        {
            _address = address.Trim();
            if (_address.Length == 0)
            {
                _address = "N/A";
            }
        }

        public string getAddress() { return _address; }

        #endregion

        #region MS Properties (Controlo por Propriedade para o WPF)

        public string Nif
        {
            get { return getNif(); }
            set { setNif(value); }
        }

        public string CompanyName
        {
            get { return getCompanyName(); }
            set { setCompanyName(value); }
        }

        public string Address
        {
            get { return getAddress(); }
            set { setAddress(value); }
        }

        #endregion

    }
}
