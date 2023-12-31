﻿using Microsoft.EntityFrameworkCore;
using MVCBasico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasico.Context
{
    public class PeliculasDataBaseContext : DbContext
    {
        public PeliculasDataBaseContext(DbContextOptions<PeliculasDataBaseContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Resena> Resenas { get; set; }
    }

}
