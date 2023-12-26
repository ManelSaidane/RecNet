using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecNet.Models.RecNet;

namespace RecNet.Controllers
{
    public class Offre : Controller
    {
        RecNetDbContext _context;
        public Offre(RecNetDbContext context)
        {
            _context = context;
        }
        // GET: Recruteur
        public async Task<IActionResult> Index()
        {
            var Offres = await _context.Offres.ToListAsync();
            return View(Offres);
        }

        // GET: Offre/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Offre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Offre/Create
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

        // GET: Offre/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Offre/Edit/5
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

        // GET: Offre/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Offre/Delete/5
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
