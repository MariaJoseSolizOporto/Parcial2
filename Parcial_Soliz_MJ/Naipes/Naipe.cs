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
        [Required(AllowEmptyStrings = false, ErrorMessage = "0 es requerido")]
        public string Nombre { get; set; }
        [Url]
        public string Imagen { get; set; }
    }
}
