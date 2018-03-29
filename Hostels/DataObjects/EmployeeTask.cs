using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hostels.DataObjects
{
    public class EmployeeTask
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Column(TypeName = "varchar")]
        public string Deescription { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}