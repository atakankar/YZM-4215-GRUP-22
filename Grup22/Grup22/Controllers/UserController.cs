using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grup22.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grup22.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Admin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login()
        {
            var isAdmin = true;

            if (isAdmin)
            {
                return RedirectToAction("Admin");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Logout()
        {
            return View();
        }
    }
}
