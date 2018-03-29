using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hostels.DataObjects
{
    public class StudentPayment
    {
        public int ID { get; set; }
        public double PaidIn { get; set; }
        public double Deposit { get; set; }
        public string Damage { get; set; }
        public double Balance { get; set; }
        public string MpesaTransaction { get; set; }

        public int StudentID { get; set; }
        public virtual Student Students { get; set; }
    }
}