using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TechConferenceCopy.Domain.Managers.Classes;
using TechConferenceCopy.Domain.Managers.Interfaces;
using TechConferenceCopy.Domain.Views;

namespace TechConferenceCopy.Controllers
{
    public class SpeakerController : Controller
    {
        private readonly ISpeakerManager speakerManager;
        public SpeakerController()
        {
            speakerManager = new SpeakerManager();
        }
        // GET: /Speaker/
        public async Task<ActionResult> Index()
        {
            SpeakerViewModel speaker = new SpeakerViewModel();

            try
            {
                speaker = await speakerManager.GetSpeakerAsync();
            }
            catch (Exception ex)
            {

                //Add logging code here
            }
            return View(speaker);
        }
	}
}