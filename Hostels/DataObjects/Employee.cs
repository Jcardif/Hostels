using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hostels.DataObjects
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required, MaxLength(256), Column(TypeName = "varchar")]
        public string FrstName { get; set; }
        [Required, MaxLength(256), Column(TypeName = "varchar")]
        public string LastName { get; set; }
        [Required, MaxLength(10), Column(TypeName = "varchar")]
        public string Phone { get; set; }
        public virtual ICollection<EmployeePayment> EmployeePayments { get; set; }
        public virtual EmployeeTask EmployeeTasks { get; set; }
    }
}