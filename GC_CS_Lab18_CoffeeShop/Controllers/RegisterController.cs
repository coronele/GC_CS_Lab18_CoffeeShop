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
            return View(new RegisterUser());
        }
        // RegUser passes back blank RegisterUser on initial load of form.
        // If server side validation (@model) fails, this will reload any previously entered data
        // Requires value defined in input type - i.e. value="@Model.UserName


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