using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasico.Models
{
   
    public class Serie : Contenido
    {
        [Display(Name = "Cantidad de Capítulos"),Range(1,1000,ErrorMessage ="Deber ser entre 1 y 1000")]
        public int cantCapitulos { set; get; }
        [Display(Name = "Cantidad de Temporadas"),Range(1, 100, ErrorMessage = "Deber ser entre 1 y 100")]
        public int cantTemporadas { set; get; }
    }
}
