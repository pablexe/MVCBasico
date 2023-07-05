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
    public class ContenidoController : Controller
    {
        private readonly PeliculasDataBaseContext _context;

        public ContenidoController(PeliculasDataBaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var peliculas = _context.Peliculas.ToList();
            var series = _context.Series.ToList();
            var contenidos = peliculas.Cast<Contenido>().Concat(series.Cast<Contenido>()).ToList();
            return View(contenidos);
        }
    }
}

