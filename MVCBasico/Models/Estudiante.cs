using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasico.Models
{
    public class Estudiante
    {
        // Lo que está entre [ ] se llaman anotaciones, y "decoran" los atributos


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        [Display(Name = "Fecha inscripción")]   //indica que mostrará el label de la página HTML
        public DateTime FechaInscripto { get; set; }
        
        [EnumDataType(typeof(Deporte))]    //indico que el SELECT del HTML, sus salen de una enumeración     
        public Deporte DeporteFavorito { get; set; }
    }
}
