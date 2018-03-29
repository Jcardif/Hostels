using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hostels.DataObjects
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FrstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<EmployeePayment> EmployeePayments { get; set; }
    }
}