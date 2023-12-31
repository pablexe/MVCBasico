﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasico.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe ingresar el nombre"), Display(Name = "Nombre"),DataType(DataType.Text)]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar el apellido"), Display(Name = "Apellido"), DataType(DataType.Text)]
        public string apellido { get; set; }
        [Required(ErrorMessage = "Debe ingresar el correo"), Display(Name = "Correo Electrónico"), RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "El correo es inválido")]
        public string correo { get; set; }
        [Required(ErrorMessage = "Debe ingresar la contraseña"), Display(Name = "Contraseña"),StringLength(10,ErrorMessage ="No puede tener mas de 10 caracteres"),DataType(DataType.Password)] 
        public string contrasenia { get; set; }
    }

}
