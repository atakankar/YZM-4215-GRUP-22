﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Grup22.Context;
using Grup22.Models;
using Microsoft.AspNetCore.Http;
using System.Web.Helpers;

namespace Grup22.Controllers
{
    public class SellerController : Controller
    {
        private readonly KurumsalContext _context;

        public SellerController(KurumsalContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var kurumsalContext = _context.Sellers.Include(s => s.sellerFactoryUser).Where(x => x.factoryUserId == HttpContext.Session.GetInt32("factoryUserId"));
            return View(await kurumsalContext.ToListAsync());
        }

        public IActionResult Create()
        {
            if (HttpContext.Session.GetInt32("factoryUserId") == null)
                return RedirectToAction(nameof(Index));
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("sellerId,sellerEmail,sellerPassword,sellerName,sellerAdress")] Seller seller)
        {
            if (ModelState.IsValid)
            {
                seller.factoryUserId = (int)HttpContext.Session.GetInt32("factoryUserId");
                seller.sellerPassword = Crypto.Hash(seller.sellerPassword, "MD5");
                _context.Add(seller);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(seller);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _context.Sellers.FindAsync(id);
            if (seller == null)
            {
                return NotFound();
            }
            return View(seller);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("sellerId,sellerEmail,sellerPassword,sellerName,sellerAdress")] Seller seller)
        {
            if (id != seller.sellerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Seller editSeller = _context.Sellers.Find(id);
                    editSeller.sellerEmail = seller.sellerEmail;
                    editSeller.sellerPassword = seller.sellerPassword = Crypto.Hash(seller.sellerPassword, "MD5");
                    editSeller.sellerName = seller.sellerName;
                    editSeller.sellerAdress = seller.sellerAdress;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SellerExists(seller.sellerId))
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
            return View(seller);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _context.Sellers
                .Include(s => s.sellerFactoryUser)
                .FirstOrDefaultAsync(m => m.sellerId == id);
            if (seller == null)
            {
                return NotFound();
            }

            return View(seller);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seller = await _context.Sellers.FindAsync(id);
            _context.Sellers.Remove(seller);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _context.Sellers
                .Include(s => s.sellerFactoryUser)
                .FirstOrDefaultAsync(m => m.sellerId == id);
            if (seller == null)
            {
                return NotFound();
            }

            return View(seller);
        }

        private bool SellerExists(int id)
        {
            return _context.Sellers.Any(e => e.sellerId == id);
        }
    }
}