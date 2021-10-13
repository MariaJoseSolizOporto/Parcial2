using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_Soliz_MJ.Naipes
{
    public class Naipe
    {
        [Key]
        public string NaipeId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage ="0 es requerido")]
        public string Nombre { get; set; }
        [Url]
        [StringLength(100, MinimumLength =10, ErrorMessage ="La longitud debe estar entre 10 y 100")]
        public string Imagen { get; set; }
    }
}
