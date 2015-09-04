using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechConferenceCopy.Domain.Views;

namespace TechConferenceCopy.Domain.Managers.Interfaces
{
    public interface ISpeakerManager
    {
        Task<SpeakerViewModel> GetSpeakerAsync();
    }
}
