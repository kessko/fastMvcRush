using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fastMvcRush.Models;

namespace fastMvcRush.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.ComeText = "Alloha Man";
            return View();
        }
        [HttpGet]
        public ActionResult RNSV()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RNSV(GuestRequest guestRequest)
        {
            //TODO send email to guest
            if (ModelState.IsValid)
            {
                return View("GuestResponse", guestRequest);
            }
            else
            {
                return View();
            }
        
        }

    }
}
