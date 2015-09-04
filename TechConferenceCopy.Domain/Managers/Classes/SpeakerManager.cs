using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechConferenceCopy.Domain.Entities;
using TechConferenceCopy.Domain.Managers.Interfaces;
using TechConferenceCopy.Domain.Repository.Classes;
using TechConferenceCopy.Domain.Repository.Interfaces;
using TechConferenceCopy.Domain.Views;

namespace TechConferenceCopy.Domain.Managers.Classes
{
    public class SpeakerManager : ISpeakerManager
    {
        private readonly ISpeakerRepository _speakerRepository;

        public SpeakerManager()
        {
            _speakerRepository = new SpeakerRepository();
        }

        public async Task<SpeakerViewModel> GetSpeakerAsync()
        {
            SpeakerViewModel speakerViewModel = new SpeakerViewModel();
            try
            {
                Speaker speaker = await _speakerRepository.GetAsync(x => x.Id > 0);
                if (speaker != null)
                {
                    speakerViewModel.FullName = speaker.FullName;
                    speakerViewModel.PictureUrl = speaker.PictureURL;
                    speakerViewModel.ShortAbstract = speaker.AchievementShort;
                }
            }
            catch (Exception ex)
            {
                //Add your logging code here.
            }
            return speakerViewModel;
        }
    }
}
