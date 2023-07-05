using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MVCBasico.Context;
using MVCBasico.Models;

namespace MVCBasico.Controllers
{
    public class ResenaController : Controller
    {
        private readonly PeliculasDataBaseContext _context;


        public ResenaController(PeliculasDataBaseContext context)
        {
            _context = context;
        }

        // GET: Reseña
        public async Task<IActionResult> Index()
        {
            return View(await _context.Resenas.
                Include(r => r.contenido).
                Include(r => r.usuario).
                ToListAsync());
        }

        // GET: REseña/Details/5
        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var resena = await _context.Resenas
                .FirstOrDefaultAsync(m => m.Id == Id);
            if (resena == null)
            {
                return NotFound();
            }

            return View(resena);
        }

        // GET: Resena/Create
        public IActionResult Create()
        {
            var peliculas = _context.Peliculas.ToList(); // Variable con todas las peliculas
            var series = _context.Series.ToList(); // Variable con todas las series
            var usuarios = _context.Usuarios.ToList();

            var contenidos = peliculas.Cast<Contenido>().Concat(series.Cast<Contenido>()); // Unificamos los contenidos de peliculas y series
            ViewBag.Contenidos = new SelectList(contenidos, "Id", "titulo");

            ViewBag.Usuarios = new SelectList(usuarios, "Id", "nombre");

            return View();
        }

        // POST: Resena/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("calificacion,comentario,usuarioId,contenidoId")] Resena resena)
        {
            if (ModelState.IsValid)
                
            {
            _context.Add(resena);
            await _context.SaveChangesAsync();       
            return RedirectToAction(nameof(Index));
            }
            return View(resena);
        }

        // GET: Resena/Edit/5
        public async Task<IActionResult> Edit(int? Id)

        {
            if (Id == null)
            {
                return NotFound();
            }

            var resena = await _context.Resenas.FindAsync(Id);
            if (resena == null)
            {
                return NotFound();
            }
            
            return View(resena);
        }

        // POST: Resena/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, [Bind("Id,calificacion,comentario")] Resena resena)
        {
            if (Id != resena.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resena);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResenaExists(resena.Id))
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
            return View(resena);
        }

        // GET: REsena/Delete/5
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var resena = await _context.Resenas
                .FirstOrDefaultAsync(m => m.Id == Id);
            if (resena == null)
            {
                return NotFound();
            }

            return View(resena);
        }

        // POST: Resenas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var resena = await _context.Resenas.FindAsync(Id);
            _context.Resenas.Remove(resena);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResenaExists(int Id)
        {
            return _context.Resenas.Any(e => e.Id == Id);
        }
    }
}
