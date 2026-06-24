using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskFlow.Helpers
{
    public class InterventionHelper
    {
        public void Insert(Models.Intervention intervention)
        {
            App.lstInterventions.Add(intervention);
        }
    }
}
