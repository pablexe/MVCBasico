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
        [Required(ErrorMessage = "Debe ingresar el título"),Display(Name = "Título")]
        public string titulo { set; get; }
        [Required(ErrorMessage = "Debe ingresar el director"), Display(Name = "Director")]
        public string director { set; get; }
        [Required(ErrorMessage = "Debe ingresar el género"), Display(Name = "Género")]
        public Genero genero { set; get; }
        [Display(Name = "Reseñas")]
        public virtual  List<Resena> resenas {set; get;} 
    }
 
}
