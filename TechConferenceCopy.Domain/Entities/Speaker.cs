﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechConferenceCopy.Domain.Entities
{
    public class Speaker
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Achievements { get; set; }
        public string AchievementShort { get; set; }
        public string Bio { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        public string Email { get; set; }
        public string Google { get; set; }
        public int Order { get; set; }
        public string PictureURL { get; set; }
        public virtual List<Session> Sessions { get; set; }

    }
}
