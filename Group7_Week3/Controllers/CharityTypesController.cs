using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Group7_Week3.Models;

namespace Group7_Week3.Controllers
{
    public class CharityTypes : Controller
    {
        public IActionResult Animals()
        {
            return View();
        }
        public IActionResult Medical()
        {
            return View();
        }
        public IActionResult Memorial()
        {
            return View();

        }
        public IActionResult Education()
        {
            return View();

        }
        public IActionResult FoodBank()
        {
            return View();

        }
        public IActionResult CancerPatient()
        {
            return View();

        }
    }
}