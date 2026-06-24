using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeskFlow.Models;

namespace DeskFlow.Helpers
{
    public class CustomerHelper
    {
        public void Insert(Customer customer)
        {
            App.lstUsers.Add(customer);
        }
    }
}
