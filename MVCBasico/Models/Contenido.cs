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
        [Display(Name = "Título")]
        public string titulo { set; get; }
        [Display(Name = "Director")]
        public string director { set; get; }
        [Display(Name = "Género")]
        public Genero genero { set; get; }
        [Display(Name = "Reseñas")]
        public List<Resena> resenas {set; get;} 
    }
 
}
