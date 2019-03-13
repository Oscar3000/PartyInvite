using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //Get RSVP form
        public IActionResult RSVP()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RSVP(PartyInviteModel guest)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Repository.Add(guest);

            return RedirectToAction("Thanks",guest);
        }

        public IActionResult Thanks(PartyInviteModel guest)
        {
            return View(guest);
        }

        public IActionResult Lists()
        {
            var guests = Repository.All();
            return View(guests.Where(n=>n.willAttend == true));
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
