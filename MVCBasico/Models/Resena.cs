using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCBasico.Models
{
    public class Resena
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Display(Name = "Calificación"),Range(1,10, ErrorMessage ="Debe ser entre 1 y 10")]
        public int calificacion { get; set; }
        [Display(Name = "Comentario")]
        public string comentario { get; set; }

        [Display(Name = "Usuario")]
        public int usuarioId { get; set; }
  
        public virtual Usuario usuario { get; set;}

        [Display(Name = "Titulo")]
        public int contenidoId { get; set; }

        public virtual Contenido contenido { get; set; }

    }
}
