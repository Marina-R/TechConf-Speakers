using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechConferenceCopy.Domain.Entities;
using TechConferenceCopy.Domain.Repository.Interfaces;

namespace TechConferenceCopy.Domain.Repository.Classes
{
    public class SessionRepository : BaseRepository<Session>, ISessionRepository
    {
    }
}
