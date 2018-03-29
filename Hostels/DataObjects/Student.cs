using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hostels.DataObjects
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        
       // public string RoomID { get; set; }

        public Room Room { get; set; }
        public ICollection<StudentPayment> StudentPayments { get; set; }
        public ICollection<Damage> Damages { get; set; }
    }
}