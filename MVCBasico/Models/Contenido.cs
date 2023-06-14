using System;
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

        public string titulo { set; get; }
        public string director { set; get; }
        public Genero genero { set; get; }
    }
}
