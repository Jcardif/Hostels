using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hostels.DataObjects
{
    public class Room
    {
        public int  Id { get; set; }
        public string RoomName { get; set; }
        public string FloorName { get; set; }
        public string Condition { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}