using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GC_CS_Lab18_CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GC_CS_Lab18_CoffeeShop.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegUser()
        {
            return View();
        }

        /*
        [HttpPost]
        public IActionResult RegUser()
        {
            return View();
        }
        */

        [HttpPost]
        public IActionResult RegWelcome(RegisterUser registerUser)
        {
            if (ModelState.IsValid)
            {
                return View(registerUser);
            }
            else
            {
                return View("RegUser", registerUser);
            }
        }
    }
}