using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hostels.DataObjects
{
    public class EmployeePayments
    {
        public int Id { get; set; }
        public double PaidOut { get; set; }
        public double Damage { get; set; }
        public double Balance { get; set; }
        public virtual ICollection<Empoyee> Empoyees { get; set; }
    }
}