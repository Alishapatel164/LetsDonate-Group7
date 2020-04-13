using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Group7_Week3.Models;

namespace Group7_Week3.Controllers
{
    public class AboutTeamController : Controller
    {
        public IActionResult Aboutus()
        {
            var team = new[]
        {
            new Team
            {
                Name = "Prit",
                Email = "prit.patel1104@gmail.com",
                Contact = "+437-343-4178",
                info="My name is Prit Patel,currently I'm doing software quality testing , i love to do testing."
            },
                new Team
            {
                Name = "Alisha",
                Email = "alishapatel79@gmail.com",
                Contact = "+567-589-2348",
                info="Myself Alisha Patel having student id 8226615, I like to do testing and playing with different tools."
            },
                     new Team
            {
                Name = "Paras",
                Email = " parasakbari77@gmail.com",
                Contact = "+478-396-6363",
                info="Hi my name is Paras Akbari and i love you play football, i also like to do testing and also want to be a developer."

            }

        };
            return View(team);
        }
    }
}