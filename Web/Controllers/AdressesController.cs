using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Api.Dal;
using System.Collections.ObjectModel;

namespace Web.Controllers
{
    public class AdressesController : Controller
    {
        private ObservableCollection<Adresse> Adresses;

        public AdressesController()
        {
			Adresses = new ObservableCollection<Adresse>();
        }

        // GET: Adresses
        public IActionResult Index()
        {
            return View(Adresses.ToList());
        }

        // GET: Adresses/Details/5
       /* public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adresse = Adresses
                .Include(a => a.Ville)
                .FirstOrDefaultAsync(m => m.AdresseId == id);
            if (adresse == null)
            {
                return NotFound();
            }

            return View(adresse);
        }*/

        // GET: Adresses/Create
        public IActionResult Create()
        {
			var Villes = new List<Ville>
			{
				new Ville{VilleId=1,Nom="Bruxelles",PaysId=1},
				new Ville{VilleId=1,Nom="Namur",PaysId=1},
				new Ville{VilleId=1,Nom="Anvers",PaysId=1},
			};
            ViewData["VilleId"] = new SelectList(Villes, "VilleId", "Nom");
            return View();
        }

        // POST: Adresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AdresseId,Rue,CodePostal,VilleId")] Adresse adresse)
        {
            if (ModelState.IsValid)
            {
                Adresses.Add(adresse);
                return RedirectToAction(nameof(Index));
            }
			var Villes = new List<Ville>
			{
				new Ville{VilleId=1,Nom="Bruxelles",PaysId=1},
				new Ville{VilleId=1,Nom="Namur",PaysId=1},
				new Ville{VilleId=1,Nom="Anvers",PaysId=1},
			};
			ViewData["VilleId"] = new SelectList(Villes, "VilleId", "Nom", adresse.VilleId);
            return View(adresse);
        }

     /*   // GET: Adresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adresse = await _context.Adresses.FindAsync(id);
            if (adresse == null)
            {
                return NotFound();
            }
            ViewData["VilleId"] = new SelectList(_context.Villes, "VilleId", "Nom", adresse.VilleId);
            return View(adresse);
        }*/

        // POST: Adresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
      /*  [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AdresseId,Rue,CodePostal,VilleId")] Adresse adresse)
        {
            if (id != adresse.AdresseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adresse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdresseExists(adresse.AdresseId))
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
            ViewData["VilleId"] = new SelectList(_context.Villes, "VilleId", "Nom", adresse.VilleId);
            return View(adresse);
        }*/

       /* // GET: Adresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adresse = await _context.Adresses
                .Include(a => a.Ville)
                .FirstOrDefaultAsync(m => m.AdresseId == id);
            if (adresse == null)
            {
                return NotFound();
            }

            return View(adresse);
        }

        // POST: Adresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adresse = await _context.Adresses.FindAsync(id);
            _context.Adresses.Remove(adresse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }*/

        private bool AdresseExists(int id)
        {
            return Adresses.Any(e => e.AdresseId == id);
        }
    }
}
