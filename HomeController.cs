using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites_Ass2_WilsonGuaman.Models;


namespace PartyInvites_Ass2_WilsonGuaman.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestRespose guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Resposes.Where(r => r.WillAttend == true));
        }
    }  
}
