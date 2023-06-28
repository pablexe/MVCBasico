using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCBasico.Models
{
    public class Resena
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required,Display(Name = "Calificación"),Range(1,10, ErrorMessage ="Debe ser entre 1 y 10")]
        public int calificacion { get; set; }
        [Display(Name = "Comentario")]
        public string comentario { get; set; }
        [Required,Display(Name = "Usuario")]
        public string usuario { get; set;}
    }
}
