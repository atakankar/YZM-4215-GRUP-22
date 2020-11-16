using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using Grup22.Context;
using Grup22.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace Grup22.Controllers
{
    public class SellerUserController : Controller
    {
        private readonly KurumsalContext _context;
        public SellerUserController(KurumsalContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetInt32("userId") == null)
                return View("~/Views/FactoryUser/Login.cshtml");
            else
                return RedirectToAction("Index","Home");
        }

        [HttpPost]
        public IActionResult Login(FactoryUser user)
        {
            Seller loginUser = _context.Sellers.FirstOrDefault(x => x.sellerEmail == user.factoryUserEmail);
            if (loginUser == null)
            {
                ViewBag.error = "Böyle bir kullanıcı kayıtlı değil";
                return View();
            }
            if (loginUser.sellerPassword == Crypto.Hash(user.factoryUserPassword, "MD5"))
            {
                HttpContext.Session.SetInt32("isFactory", 0);
                HttpContext.Session.SetInt32("userId", loginUser.factoryUserId);
                HttpContext.Session.SetString("userEmail", loginUser.sellerEmail);
                HttpContext.Session.SetString("userName", loginUser.sellerName);
                return RedirectToAction("Index", "Home");
            }
            ViewBag.error = "Yanlış Şifre";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View("~/Views/FactoryUser/ForgotPassword.cshtml");
        }

        [HttpPost]
        public IActionResult ForgotPassword(string userEmail)
        {
            Seller user = _context.Sellers.FirstOrDefault(x => x.sellerEmail == userEmail);
            if (user == null)
            {
                ViewBag.error = "Email adresi yanlış veya böyle bir kullanıcı kayıtlı değil!";
            }
            else
            {
                Random rnd = new Random();
                var number = rnd.Next();
                var newPassword = Crypto.Hash(number.ToString(), "MD5");
                user.sellerPassword = newPassword;
                _context.SaveChanges();

                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("abbadabaka@gmail.com"));
                email.To.Add(MailboxAddress.Parse(user.sellerEmail));
                email.Subject = "Şifre Yenileme";
                email.Body = new TextPart(TextFormat.Plain) { Text = "Sayın '" + user.sellerName + "', Yeni Şifreniz: " + number };

                using var smtp = new SmtpClient();
                smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("abbadabaka@gmail.com", "asdfgh1346");
                smtp.Send(email);
                smtp.Disconnect(true);
                ViewBag.error = "Yeni şifreniz Email adresinize gönderildi!";
            }
            return View();
        }
    }
}
