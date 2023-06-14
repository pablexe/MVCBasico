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
        public int cantCapitulos { set; get; }
        public int cantTemporadas { set; get; }
    }
}
