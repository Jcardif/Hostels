using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hostels.DataObjects
{
    public class StudentPayment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public double PaidIn { get; set; }
        [Required]
        public double Deposit { get; set; }
        [Required, Column(TypeName = "varchar")]
        public string Damage { get; set; }
        [Required]
        public double Balance { get; set; }
        [Column(TypeName = "varchar")]
        public string MpesaTransaction { get; set; }

        public int StudentID { get; set; }
        public virtual Student Students { get; set; }
    }
}