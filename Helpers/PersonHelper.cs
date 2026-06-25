using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeskFlow.Models;

namespace DeskFlow.Helpers
{
    public class PersonHelper
    {
        public void Insert(Customer customer)
        {
            App.lstUsers.Add(customer);
        }

        public void Update(Customer customer)
        {
            var existingCustomer = App.lstUsers.OfType<Customer>().FirstOrDefault(c => c.Email == customer.Email);
            if (existingCustomer != null)
            {
                existingCustomer.Name = customer.Name;
                existingCustomer.CompanyName = customer.CompanyName;
                existingCustomer.Nif = customer.Nif;
            }
        }
    }
}
