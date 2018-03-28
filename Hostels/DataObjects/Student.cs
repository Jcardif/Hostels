using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hostels.DataObjects
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


        public int PaymentId { get; set; }
        public string RoomId { get; set; }
        public Room Room { get; set; }
        public StudentPayment StudentPayment { get; set; }
        public ICollection<Damage> Damages { get; set; }
    }
}