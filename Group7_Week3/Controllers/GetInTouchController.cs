using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataModels;
using Library.BusinessLogic;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace Group7_Week3.Controllers
{
    public class GetInTouchController : Controller
    {
        private IConfiguration _configuration;
        //public GetInTouchController() { }
        public GetInTouchController(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        [HttpGet]
        public IActionResult Contactus()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contactus(GetInTouch1 contact1)
        {
            ContactHandler handler = new ContactHandler(_configuration);
            var newGetInTouch1 = handler.AddGetInTouch1(contact1);

            //contact1.DateCreated = DateTime.Now;
            return RedirectToAction("Listing");
        }
        public IActionResult Listing()
        {
            ContactHandler handler = new ContactHandler(_configuration);

            var contacts = handler.GetAllGetInTouch1();

            return View(contacts);
        }
    }
}