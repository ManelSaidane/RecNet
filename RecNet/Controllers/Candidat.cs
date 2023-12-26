﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecNet.Models.RecNet;

namespace RecNet.Controllers
{
    public class Candidat : Controller
    {
        RecNetDbContext _context;
        public Candidat(RecNetDbContext context)
        {
            _context = context;
        }
        // GET: Recruteur
        public async Task<IActionResult> Index()
        {
            var Candidats = await _context.Candidats.ToListAsync();
            return View(Candidats);
        }
        // GET: Candidat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Candidat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Candidat/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Candidat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Candidat/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Candidat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Candidat/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
