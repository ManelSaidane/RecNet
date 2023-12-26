using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecNet.Models.RecNet;

namespace RecNet.Controllers
{
    public class Recruteur : Controller
    {
        RecNetDbContext _context;
        public Recruteur(RecNetDbContext context)
        {
            _context = context;
        }
        // GET: Recruteur
        public async Task<IActionResult> Index()
        {
            var recruteurs = await _context.Recruteurs.ToListAsync();
            return View(recruteurs);
        }

        // GET: Recruteur/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Recruteur/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recruteur/Create
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

        // GET: Recruteur/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Recruteur/Edit/5
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

        // GET: Recruteur/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Recruteur/Delete/5
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
