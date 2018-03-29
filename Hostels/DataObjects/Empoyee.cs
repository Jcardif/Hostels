using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hostels.DataObjects
{
    public class Empoyee
    {
        public int ID { get; set; }
        public string FrstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public EmployeePayments EmployeePayments { get; set; }
    }
}