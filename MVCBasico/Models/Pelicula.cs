using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasico.Models
{
  
    public class Pelicula : Contenido
    {
        [Required,Display(Name = "Duración"),Range(0,250, ErrorMessage ="Por favor ingrese un número entre 0 y 250")]
        public double duracion { set; get; }
    }
}
