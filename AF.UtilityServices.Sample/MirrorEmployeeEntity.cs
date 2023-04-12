using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.UtilityServices.Sample
{
    public sealed class MirrorEmployeeEntity
    {
        public Guid EmployeeID { get; set; }

        public String Address { get; set; }

        public String Phone { get; set; }

        public Double Salary { get; set; }

        public String Name { get; set; }
    }
}
