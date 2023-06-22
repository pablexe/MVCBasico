﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasico.Models
{
    public class Contenido
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string titulo { set; get; }
        public string director { set; get; }
        public Genero genero { set; get; }
        public Resena Resena { set; get; } // ESto debe ser Array List
    }
}
