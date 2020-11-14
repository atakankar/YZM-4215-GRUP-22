﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Grup22.Context;
using Grup22.Models;
using System.Web.Helpers;
using System.Web;
using System.Net;
using MimeKit;
using MimeKit.Text;

using MailKit.Security;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;

namespace Grup22.Controllers
{
    public class FactoryUserController : Controller
    {
        private readonly KurumsalContext _context;

        public FactoryUserController(KurumsalContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(FactoryUser user)
        {
            if (ModelState.IsValid)
            {
                if (_context.factoryUsers.FirstOrDefault(x => x.factoryUserEmail == user.factoryUserEmail) != null)
                {
                    ViewBag.result = "Email adresi zaten kayıtlı!";
                    return View();
                }
                // Kullanıcının şifresi MD5 şifreleme kullanarak veritabanına kaydediliyor
                user.factoryUserPassword = Crypto.Hash(user.factoryUserPassword, "MD5");
                _context.Add(user);
                _context.SaveChanges();
                ViewBag.result = "Başarıyla kayıt oldunuz. Giriş sayfasına yönlendiriliyorsunuz.";

                // Mail oluşturma
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("abbadabaka@gmail.com"));
                email.To.Add(MailboxAddress.Parse(user.factoryUserEmail));
                email.Subject = "Sisteme Kayıt";
                email.Body = new TextPart(TextFormat.Plain) { Text = "Sayın '" + user.factoryUserName + "', Bizimle Çalıştığınız İçin Teşekkür Ederiz" };

                // SMTP(Elektronik posta gönderme protokolü) kullanarak oluşturulan maili gönderme
                using var smtp = new SmtpClient();
                smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("abbadabaka@gmail.com", "asdfgh1346");
                smtp.Send(email);
                smtp.Disconnect(true);

                //ViewBag.Message = string.Format("Başarıyla kayıt oldunuz. Giriş sayfasına yönlendiriliyorsunuz.");
                //System.Threading.Thread.Sleep(1000);
                return RedirectToAction("Login");
            }
            ViewBag.result = "Lütfen tüm alanları doldurunuz";
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(FactoryUser user)
        {
            FactoryUser loginUser = _context.factoryUsers.FirstOrDefault(x => x.factoryUserEmail == user.factoryUserEmail);
            if (loginUser == null)
            {
                ViewBag.error = "Böyle bir kullanıcı kayıtlı değil";
                return View();
            }
            // Kullanıcının girdiği şifrenin tekrar MD5 şifreleme algoritması kullanılarak hash'i çıkarılıyor ve çıkan sonuçlar karşılaştırılıyor.
            //Böylelikle kullanıcının şifresinin güvenliği sağlanıyor.
            if (loginUser.factoryUserPassword == Crypto.Hash(user.factoryUserPassword, "MD5"))
            {
                HttpContext.Session.SetInt32("factoryUserId", loginUser.factoryUserId);
                HttpContext.Session.SetString("factoryUserEmail", loginUser.factoryUserEmail);
                HttpContext.Session.SetString("factoryUserName", loginUser.factoryUserName);

                //HttpContext.Session.SetString("isUserLogin", "true"); // Yeni bir session oluşturma.
                //HttpContext.Session.GetString("isUserLogin"); // Sessiondan değer getirme.
                //HttpContext.Session.Clear(); // Tüm sessionları temizleme.

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
            return View();
        }

        [HttpPost]
        public IActionResult ForgotPassword(string userEmail)
        {
            FactoryUser user = _context.factoryUsers.FirstOrDefault(x => x.factoryUserEmail == userEmail);
            if (user == null)
            {
                ViewBag.error = "Email adresi yanlış veya böyle bir kullanıcı kayıtlı değil!";
            }
            else
            {
                Random rnd = new Random();
                var number = rnd.Next();
                var newPassword = Crypto.Hash(number.ToString(), "MD5");
                user.factoryUserPassword = newPassword;
                _context.SaveChanges();

                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("abbadabaka@gmail.com"));
                email.To.Add(MailboxAddress.Parse(user.factoryUserEmail));
                email.Subject = "Şifre Yenileme";
                email.Body = new TextPart(TextFormat.Plain) { Text = "Sayın '" + user.factoryUserName + "', Yeni Şifreniz: " + number };

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