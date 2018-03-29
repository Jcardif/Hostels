using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hostels.DataObjects
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required, Column(TypeName = "varchar")]
        public string FirstName { get; set; }
        [Required, Column(TypeName = "varchar")]
        public string LastName { get; set; }
        [Required, Column(TypeName = "varchar")]
        public string Phone { get; set; }
        [Required, Column(TypeName = "varchar")]
        public string Email { get; set; }
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";


        // public string RoomID { get; set; }

        public Room Room { get; set; }
        public ICollection<StudentPayment> StudentPayments { get; set; }
        public ICollection<Damage> Damages { get; set; }
    }
}