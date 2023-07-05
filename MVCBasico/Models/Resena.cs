using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCBasico.Models
{
    public class Resena
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar una calificación"),Display(Name = "Calificación"),Range(1,10, ErrorMessage ="Debe ser entre 1 y 10")]
        public int calificacion { get; set; }
        [Required(ErrorMessage = "Debe ingresar un comentario"),Display(Name = "Comentario")]
        public string comentario { get; set; }


        [Required(ErrorMessage = "Debe ingresar un usuario"),Display(Name = "Usuario")]
        public int usuarioId { get; set; }

        [Display(Name = "Usuario")]
        public virtual Usuario usuario { get; set;}

        [Required(ErrorMessage = "Debe seleccionar el contenido"),Display(Name = "Contenido")]
        public int contenidoId { get; set; }
        [Display(Name = "Contenido")]
        public virtual Contenido contenido { get; set; }

    }
}
