using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechConferenceCopy.Domain.Entities
{
    public class Session
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Info { get; set; }
        public string ShortInfo { get; set; }
        public string SessionUrl { get; set; }
        public bool Lunch { get; set; }
        public virtual Track Track { get; set; }
        public virtual TimeSlot TimeSlot { get; set; }
        public virtual List<Speaker> Speakers { get; set; }
    }
}
