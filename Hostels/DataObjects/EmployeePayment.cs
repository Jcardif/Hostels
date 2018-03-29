using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hostels.DataObjects
{
    public class EmployeePayment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
       [Required]
        public double PaidOut { get; set; }
        [Required]
        public double Damage { get; set; }
        [Required]
        public double Balance { get; set; }
        [Required]
        public int EmployeeID { get; set; }
        public virtual Employee Empoyee { get; set; }
    }
}