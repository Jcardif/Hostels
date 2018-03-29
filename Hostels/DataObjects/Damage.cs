using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hostels.DataObjects
{
    public class Damage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string  Description { get; set; }
        public double Charges { get; set; }

        public int StudentID { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}