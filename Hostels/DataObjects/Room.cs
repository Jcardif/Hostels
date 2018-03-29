using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hostels.DataObjects
{
    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  ID { get; set; }
        [Required, MaxLength(50), Column(TypeName = "varchar")]
        public string RoomName { get; set; }
        [Required, Column(TypeName = "varchar")]
        public string FloorName { get; set; }
        [Required, Column(TypeName = "varchar")]
        public string Condition { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}