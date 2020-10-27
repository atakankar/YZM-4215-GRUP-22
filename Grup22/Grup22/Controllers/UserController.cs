using System;
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
    public class UserController : Controller
    {
        private readonly KurumsalContext _context;

        public UserController(KurumsalContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(fact_User user)
        {
            if (ModelState.IsValid)
            {
                if (_context.fact_Users.FirstOrDefault(x => x.fact_Email == user.fact_Email) != null)
                {
                    ViewBag.result = "Email adresi zaten kayıtlı!";
                    return View();
                }
                // Kullanıcının şifresi MD5 şifreleme kullanarak veritabanına kaydediliyor
                user.fact_Password = Crypto.Hash(user.fact_Password, "MD5");
                _context.Add(user);
                _context.SaveChanges();
                ViewBag.result = "Başarıyla kayıt oldunuz. Giriş sayfasına yönlendiriliyorsunuz.";

                // Mail oluşturma
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("abbadabaka@gmail.com"));
                email.To.Add(MailboxAddress.Parse(user.fact_Email));
                email.Subject = "Sisteme Kayıt";
                email.Body = new TextPart(TextFormat.Plain) { Text = "Sayın '" + user.fact_Name + "', Bizimle Çalıştığınız İçin Teşekkür Ederiz" };

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
        public IActionResult Login(fact_User user)
        {
            /*if(user==null)
            {
                return new System.Web.Mvc.HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }*/
            fact_User loginUser = _context.fact_Users.FirstOrDefault(x => x.fact_Email == user.fact_Email);
            if (loginUser == null)
            {
                ViewBag.error = "Böyle bir kullanıcı kayıtlı değil";
                return View();
            }
            // Kullanıcının girdiği şifrenin tekrar MD5 şifreleme algoritması kullanılarak hash'i çıkarılıyor ve çıkan sonuçlar karşılaştırılıyor.
            //Böylelikle kullanıcının şifresinin güvenliği sağlanıyor.
            if (loginUser.fact_Password == Crypto.Hash(user.fact_Password, "MD5"))
            {
                HttpContext.Session.SetString("fact_Id", loginUser.fact_Id.ToString());
                HttpContext.Session.SetString("fact_Email", loginUser.fact_Email);
                HttpContext.Session.SetString("fact_Name", loginUser.fact_Name);

                //HttpContext.Session.SetString("isUserLogin", "true"); // Yeni bir session oluşturma.
                //HttpContext.Session.GetString("isUserLogin"); // Sessiondan değer getirme.
                //HttpContext.Session.Clear(); // Tüm sessionları temizleme.

                return RedirectToAction("Index", "Home");
            }
            ViewBag.error = "Yanlış Şifre";
            return View();
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fact_User = await _context.fact_Users
                .FirstOrDefaultAsync(m => m.fact_Id == id);
            if (fact_User == null)
            {
                return NotFound();
            }

            return View(fact_User);
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fact_User = await _context.fact_Users.FindAsync(id);
            if (fact_User == null)
            {
                return NotFound();
            }
            return View(fact_User);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("fact_Id,fact_Email,fact_Password,fact_Name,fact_Adress")] fact_User fact_User)
        {
            if (id != fact_User.fact_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fact_User);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!fact_UserExists(fact_User.fact_Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(fact_User);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fact_User = await _context.fact_Users
                .FirstOrDefaultAsync(m => m.fact_Id == id);
            if (fact_User == null)
            {
                return NotFound();
            }

            return View(fact_User);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fact_User = await _context.fact_Users.FindAsync(id);
            _context.fact_Users.Remove(fact_User);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool fact_UserExists(int id)
        {
            return _context.fact_Users.Any(e => e.fact_Id == id);
        }
    }
}
