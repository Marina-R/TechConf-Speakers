﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechConferenceCopy.Domain.Entities
{
    public class TimeSlot
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public int Order { get; set; }

    }
}
