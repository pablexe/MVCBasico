using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCBasico.Context;
using MVCBasico.Models;

namespace MVCBasico.Controllers
{
    public class SerieController : Controller
    {
        private readonly PeliculasDataBaseContext _context;

        public SerieController(PeliculasDataBaseContext context)
        {
            _context = context;
        }

        // GET: Serie
        public async Task<IActionResult> Index()
        {
            return View(await _context.Series.ToListAsync());
        }

        // GET: SErie/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serie = await _context.Series
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serie == null)
            {
                return NotFound();
            }

            return View(serie);
        }

        // GET: Serie/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Series/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,titulo,director,genero,cantCapitulos,cantTemporadas")] Serie serie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(serie);
        }

        // GET: Serie/Edit/5
        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var serie = await _context.Series.FindAsync(Id);
            if (serie == null)
            {
                return NotFound();
            }
            return View(serie);
        }

        // POST: Serie/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, [Bind("Id,titulo,director,genero,cantCapitulos,cantTemporadas")] Serie serie)
        {
            if (Id != serie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(serie.Id))
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
            return View(serie);
        }

        // GET: SErie/Delete/5
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var serie = await _context.Series
                .FirstOrDefaultAsync(m => m.Id == Id);
            if (serie == null)
            {
                return NotFound();
            }

            return View(serie);
        }

        // POST: Serie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var serie = await _context.Series.FindAsync(Id);
            _context.Series.Remove(serie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int Id)
        {
            return _context.Series.Any(e => e.Id == Id);
        }
    }
}
