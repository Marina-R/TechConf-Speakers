using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechConferenceCopy.Domain.Context;
using TechConferenceCopy.Domain.Entities;


namespace TechConferenceCopy.Controllers
{
    public class NewSpeakerController : Controller
    {
        //
        // GET: /NewSpeaker/
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Speaker speaker)
        {
            if (ModelState.IsValid)
            {
                using (TechContext db = new TechContext())
                {
                    db.Speaker.Add(speaker);
                    db.SaveChanges();
                    ModelState.Clear();
                    speaker = null;
                    ViewBag.Message = "Successfully Registration Done";
                    TempData["Success"] = "Success message text.";
                    return RedirectToAction("Index", "Home");
                }
            } else
            return View(speaker);
            //return RedirectToAction("Index", "Home");
        }
	}
}