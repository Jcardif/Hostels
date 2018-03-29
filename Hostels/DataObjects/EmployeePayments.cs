﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hostels.DataObjects
{
    public class EmployeePayments
    {
        public int ID { get; set; }
        public double PaidOut { get; set; }
        public double Damage { get; set; }
        public double Balance { get; set; }
        public int EmployeeID { get; set; }
        public virtual Empoyee Empoyee { get; set; }
    }
}