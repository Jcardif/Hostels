using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.Azure.Mobile.Server;

namespace Hostels.DataObjects
{
    public class Damage 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(256), Column(TypeName = "varchar")]
        public string  Description { get; set; }
        [Required]
        public double Charges { get; set; }

        public int StudentID { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}