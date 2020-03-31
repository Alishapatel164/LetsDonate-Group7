using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataModels;
using Library.BusinessLogic;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Group7_Week3.Models;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Group7_Week3.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _configuration;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;

        }
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Donation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Donation(Donation donate1)
        {
            ContactHandler handler = new ContactHandler(_configuration);
            var newDonation1 = handler.AddDonations(donate1);
            return View();
        }
        public IActionResult Organization()
        {
            Donation db = new Donation();
            ViewBag.Organization = new SelectList(db.Organization, "Organization");
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Test()
        {
            return View();
        }

    }
}
